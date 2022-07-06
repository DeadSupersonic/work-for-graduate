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
    /// Логика взаимодействия для Adress.xaml
    /// </summary>
    public partial class Adress : Page
    {
        santoriniEntities context;
        public Adress()
        {
            InitializeComponent();
            context = new santoriniEntities();
            var r = DataGridRegistration.SelectedItem as address;
            //вывод данных таблицы официант в таблицу на странице
            DataGridRegistration.ItemsSource = context.address.ToList();
            choose.ItemsSource = context.cafe.ToList();
            ps.ItemsSource = context.personal.ToList();
            cn.ItemsSource = context.cafe.ToList();
        }

        private void ButtonAdd_click(object sender, RoutedEventArgs e)
        {
            //переход другую на страницу с целью добавления новой строки
            NavigationService.Navigate(new Add_adress());
            DataGridRegistration.ItemsSource = context.address.ToList();
        }
        private void ButtonDel_click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as address;
            if (r == null)
            {
                MessageBox.Show("Выберете не пустую строку!", "Удалить", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //удаление строки
            MessageBoxResult result = MessageBox.Show("Вы действитедьно хотите удалить запись?", "Удалить?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    context.address.Remove(r);
                    context.SaveChanges();
                    DataGridRegistration.ItemsSource = context.address.ToList();
                }
                catch
                {
                    MessageBox.Show("Этот адрес ещё используется", "Отменить удаление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ButtonCh_Click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as address;
            if (r == null)
            {
                MessageBox.Show("Не были выбраны данные для изменения", "Изменить", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                //изменение строки
                DataGridRegistration.DataContext = context.SaveChanges();
                NavigationService.Navigate(new Adress());
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (search.Text != null)
            {
                DataGridRegistration.ItemsSource = context.address.Where(z => z.city.ToString().Contains(search.Text.ToLower())||
                z.country.ToString().Contains(search.Text.ToLower())|| z.street.ToString().Contains(search.Text.ToLower())).ToList();
            }
            else if (string.IsNullOrWhiteSpace(search.Text))
            {
                NavigationService.Navigate(new Adress());
            }
        }

        private void choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int cafe = Convert.ToInt32(choose.SelectedValue);
            DataGridRegistration.ItemsSource = context.address.Where(z => z.idc == cafe).ToList();
        }
    }
}
