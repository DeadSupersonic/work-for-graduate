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
using System.Windows.Shapes;
using karg.pages;
using System.Resources;

namespace karg
{
    /// <summary>
    /// Логика взаимодействия для главная.xaml
    /// </summary>
    public partial class главная : Window
    {
        public главная()
        {
            InitializeComponent();
            string[] mas = {"blue", "coffee"};
            cb.ItemsSource = mas;
        }
        //переход по страницам в зависимости от того, на какую кнопку нажать
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            //возвращаемся на окно авторизации
            var z = new MainWindow();
            this.Close();
            z.ShowDialog();
        }

        private void Personal_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Personal());
            Title = "Персонал";
        }

        private void Cafe_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Cafe());
            Title = "Кафе";
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Product());
            Title = "Продукт";
        }

        private void Adress_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Adress());
            Title = "Адрес";
        }

        private void Work_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Work());
            Title = "Должности";
        }

        private void Telephone_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Telephone());
            Title = "Номера телефонов";
        }

        private void Postavka_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Postavka());
            Title = "Поставщики";
        }

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Statistic());
            Title = "Статистика";
        }

        private void Cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Convert.ToString(cb.SelectedValue) == "coffee")
            {
                grid.Background = new SolidColorBrush(Colors.BlanchedAlmond);
                changecolor.Foreground = new SolidColorBrush(Colors.Chocolate);
                name.Foreground = new SolidColorBrush(Colors.Chocolate);
                Application.Current.Resources["gb"] = Application.Current.Resources["gc"];
                Application.Current.Resources["dgb"] = Application.Current.Resources["dgc"];
                Application.Current.Resources["rb"] = Application.Current.Resources["rc"];
            }
            else if(Convert.ToString(cb.SelectedValue) == "blue")
            {
                grid.Background = new SolidColorBrush(Color.FromRgb(158, 205, 249));
                changecolor.Foreground = new SolidColorBrush(Colors.DarkBlue);
                name.Foreground = new SolidColorBrush(Colors.DarkBlue);
                Application.Current.Resources["gb"] = Application.Current.Resources["glb"];
                Application.Current.Resources["dgb"] = Application.Current.Resources["dglb"];
                Application.Current.Resources["rb"] = Application.Current.Resources["rlb"];
            }
        }

        private void backPhoto_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Title = "Главная";
            frame.NavigationService.Navigate(Icon);
            frame.Content = null;
        }
    }
}
