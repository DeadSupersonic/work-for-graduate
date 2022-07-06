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
    /// Логика взаимодействия для Add_Telephone.xaml
    /// </summary>
    public partial class Add_Telephone : Page
    {
        santoriniEntities context;
        public Add_Telephone()
        {
            InitializeComponent();
            context = new santoriniEntities();
            surname.ItemsSource = context.personal.ToList();
        }

        private void ButtonSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            //проверка на существование такой строки
            if (context.telephone.Any(o => o.number == number.Text))
            {
                MessageBox.Show("Такой номер уже существует", "Повторить ввод", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(number.Text))
                    error.AppendLine("Введите верный номер телефона");
                if (surname.SelectedValue == null)
                    error.AppendLine("Выберите фамилию сотрудника");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка при вводе данных", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                context.telephone.Add(new telephone //добавление строки в таблицу
                {
                    number = number.Text,
                    idp = Convert.ToInt32(surname.SelectedValue),
                });
                context.SaveChanges();//сохранение новой строки
                NavigationService.Navigate(new Telephone());
            }
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Telephone());
        }
        //переход по полям для ввода при помощи стрелок на клавиатуре
        private void number_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) surname.Focus();
        }
        private void surname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up) number.Focus();
        }
    }
}
