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
using System.Drawing;
using System.Drawing.Configuration;
using System.Configuration;

namespace karg.pages
{
    /// <summary>
    /// Логика взаимодействия для Telephone.xaml
    /// </summary>
    public partial class Telephone : Page
    {
        santoriniEntities context;
        public Telephone()
        {
            InitializeComponent();
            context = new santoriniEntities();
            //вывод данных таблицы официант в таблицу на странице
            DataGridRegistration.ItemsSource = context.telephone.ToList();
            choose.ItemsSource = context.personal.ToList();
            ps.ItemsSource= context.personal.ToList();
        }

        private void ButtonAdd_click(object sender, RoutedEventArgs e)
        {
            //переход другую на страницу с целью добавления новой строки
            NavigationService.Navigate(new Add_Telephone());
            DataGridRegistration.ItemsSource = context.telephone.ToList();
        }
        private void ButtonDel_click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as telephone;
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
                    context.telephone.Remove(r);
                    context.SaveChanges();
                    DataGridRegistration.ItemsSource = context.telephone.ToList();
                }
                catch
                {
                    MessageBox.Show("Этот номер телефона ещё используется одним из сотрудников", "Отменить удаление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ButtonCh_Click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as telephone;
            if (r == null)
            {
                MessageBox.Show("Не были выбраны данные для изменения", "Изменить", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                //изменение строки
                DataGridRegistration.DataContext = context.SaveChanges();
                NavigationService.Navigate(new Telephone());
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (search.Text != null)
            {
                DataGridRegistration.ItemsSource = context.telephone.Where(z => z.number.ToString().Contains(search.Text.ToLower())).ToList();
            }
            else if(string.IsNullOrWhiteSpace(search.Text))
            {
                NavigationService.Navigate(new Telephone());
            }
        }

        private void choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int per = Convert.ToInt32(choose.SelectedValue);
            DataGridRegistration.ItemsSource = context.telephone.Where(z => z.idp == per).ToList();
        }
    }
}
