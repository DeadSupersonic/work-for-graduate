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
    /// Логика взаимодействия для Personal.xaml
    /// </summary>
    public partial class Personal : Page
    {
        santoriniEntities context;
        public Personal()
        {
            InitializeComponent();
            context = new santoriniEntities();
            //вывод данных таблицы официант в таблицу на странице
            DataGridRegistration.ItemsSource = context.personal.ToList();
            choose.ItemsSource = context.cafe.ToList();
            sal.ItemsSource = context.work.ToList();
            pos.ItemsSource = context.work.ToList();
            c.ItemsSource = context.cafe.ToList();
        }

        private void ButtonAdd_click(object sender, RoutedEventArgs e)
        {
            //переход другую на страницу с целью добавления новой строки
            NavigationService.Navigate(new Add_personal());
            DataGridRegistration.ItemsSource = context.personal.ToList();
        }
        private void ButtonDel_click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as personal;
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
                    context.personal.Remove(r);
                    context.SaveChanges();
                    DataGridRegistration.ItemsSource = context.personal.ToList();
                }
                catch
                {
                    MessageBox.Show("У этого исполнителя есть заказ", "Отменить удаление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ButtonCh_Click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as personal;
            if (r == null)
            {
                MessageBox.Show("Не были выбраны данные для изменения", "Изменить", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                //изменение строки
                DataGridRegistration.DataContext = context.SaveChanges();
                NavigationService.Navigate(new Personal());
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (search.Text!= null)
            {
                DataGridRegistration.ItemsSource = context.personal.Where(z => z.surname.ToString().Contains(search.Text.ToLower())||
                z.name.ToString().Contains(search.Text.ToLower())|| z.lastname.ToString().Contains(search.Text.ToLower())
                || z.work.position.ToString().Contains(search.Text.ToLower())).ToList();
            }
            else if(string.IsNullOrWhiteSpace(search.Text))
            {
                NavigationService.Navigate(new Personal());
            }
        }

        private void choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int cafe = Convert.ToInt32(choose.SelectedValue);
            DataGridRegistration.ItemsSource = context.personal.Where(z => z.idc == cafe).ToList();
        }
    }
}
