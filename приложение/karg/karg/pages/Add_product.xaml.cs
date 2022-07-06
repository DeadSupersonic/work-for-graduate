using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace karg.pages
{
    /// <summary>
    /// Логика взаимодействия для Add_product.xaml
    /// </summary>
    public partial class Add_product : Page
    {
        santoriniEntities context;
        public Add_product()
        {
            InitializeComponent();
            context = new santoriniEntities();
            idc.ItemsSource = context.cafe.ToList();
            idsp.ItemsSource = context.supply.ToList();
            string[] qualitymas = { "плохое", "среднее", "хорошое", "отличное" };
            qua.ItemsSource = qualitymas;
        }

        private void ButtonSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            //проверка на существование такой строки
            if (context.product.Any(o => o.name == name.Text) && context.product.Any(o => o.idsp == Convert.ToInt32(idsp.Text)) && context.product.Any(o => o.idc == Convert.ToInt32(idc.Text)))
            {
                MessageBox.Show("Такой продукт уже есть на складе", "Повторить ввод", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(name.Text))
                    error.AppendLine("Введите наименование продукта");
                if (string.IsNullOrEmpty(enter.Text) || Convert.ToDateTime(enter.Text) == null)
                    error.AppendLine("Введите верную дату привоза");
                if (string.IsNullOrEmpty(srok.Text) || Convert.ToDateTime(srok.Text) == null)
                    error.AppendLine("Введите верный срок годности");
                if (string.IsNullOrEmpty(pr.Text) || Convert.ToInt32(pr.Text)<0)
                    error.AppendLine("Введите верную стоимость");
                if (qua.SelectedValue == null)
                    error.AppendLine("Выберите качество");
                if (string.IsNullOrEmpty(how.Text))
                    error.AppendLine("Введите количество товара");
                if (idsp.SelectedValue == null)
                    error.AppendLine("Выберите наименование поставщика");
                if (idc.SelectedValue == null)
                    error.AppendLine("Выберите наименование кафе");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка при вводе данных", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                context.product.Add(new product //добавление строки в таблицу
                {
                    name = name.Text,
                    date_get = Convert.ToDateTime(enter.Text),
                    before_date = Convert.ToDateTime(srok.Text),
                    price=Convert.ToInt32(pr.Text),
                    quality=Convert.ToString(qua.SelectedValue),
                    how_much = how.Text,
                    idsp = Convert.ToInt32(idsp.SelectedValue),
                    idc = Convert.ToInt32(idc.SelectedValue),
                });
                context.SaveChanges();//сохранение новой строки
                NavigationService.Navigate(new Product());
            }
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Product());
        }
        //переход по полям для ввода при помощи стрелок на клавиатуре
        private void name_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) enter.Focus();
        }

        private void enter_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) srok.Focus();
            if (e.Key == Key.Up) name.Focus();
        }

        private void srok_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) pr.Focus();
            if (e.Key == Key.Up) enter.Focus();
        }
        private void how_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) idsp.Focus();
            if (e.Key == Key.Up) qua.Focus();
        }

        private void who_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) idc.Focus();
            if (e.Key == Key.Up) how.Focus();
        }

        private void idc_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up) idsp.Focus();
        }

        private void qua_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) how.Focus();
            if (e.Key == Key.Up) pr.Focus();
        }

        private void pr_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) qua.Focus();
            if (e.Key == Key.Up) srok.Focus();
        }
    }
}
