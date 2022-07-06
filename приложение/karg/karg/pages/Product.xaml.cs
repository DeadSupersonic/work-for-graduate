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
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        santoriniEntities context;
        public Product()
        {
            InitializeComponent();
            context = new santoriniEntities();
            //вывод данных таблицы официант в таблицу на странице
            DataGridRegistration.ItemsSource = context.product.ToList();
            choose.ItemsSource = context.cafe.ToList();
            sup.ItemsSource = context.supply.ToList();
            c.ItemsSource= context.cafe.ToList();
            string[] mas = { "плохое", "среднее", "хорошое", "отличное" };
            qua.ItemsSource = mas;
            var r = DataGridRegistration.SelectedItem as product;
            DateTime date = DateTime.Now.Date;
            if (context.product.Where(z => z.before_date < date).Count()!=0)
            {
                DataGridRegistration.RowBackground = new SolidColorBrush(Colors.Red);
            }
        }

        private void ButtonAdd_click(object sender, RoutedEventArgs e)
        {
            //переход другую на страницу с целью добавления новой строки
            NavigationService.Navigate(new Add_product());
            DataGridRegistration.ItemsSource = context.product.ToList();
        }
        private void ButtonDel_click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as product;
            if (r == null)
            {
                MessageBox.Show("Выберете не пустую строку!", "Удалить", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //удаление строки
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    context.product.Remove(r);
                    context.SaveChanges();
                    DataGridRegistration.ItemsSource = context.product.ToList();
                }
                catch
                {
                    MessageBox.Show("Этот продукт ещё используется в приготовлении", "Отменить удаление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ButtonCh_Click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as product;
            if (r == null)
            {
                MessageBox.Show("Не были выбраны данные для изменения", "Изменить", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                //изменение строки
                DataGridRegistration.DataContext = context.SaveChanges();
                NavigationService.Navigate(new Product());
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (search.Text != null)
            {
                DataGridRegistration.ItemsSource = context.product.Where(z => z.name.ToString().Contains(search.Text.ToLower())).ToList();
            }
            else if (string.IsNullOrWhiteSpace(search.Text))
            {
                NavigationService.Navigate(new Product());
            }
        }

        private void choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int cafe = Convert.ToInt32(choose.SelectedValue);
            DataGridRegistration.ItemsSource = context.personal.Where(z => z.idc == cafe).ToList();
        }
    }
}
