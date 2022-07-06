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
    /// Логика взаимодействия для Add_adress.xaml
    /// </summary>
    public partial class Add_adress : Page
    {
        santoriniEntities context;
        public Add_adress()
        {
            InitializeComponent();
            context = new santoriniEntities();
            idp.ItemsSource = context.personal.ToList();
            idc.ItemsSource = context.cafe.ToList();
        }

        private void ButtonSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            int ip,ic;
            if(idp.SelectedValue==null)
            {
                ip = 0;
            }
            else
            {
                ip = Convert.ToInt32(idp.SelectedValue);
            }
            if(idc.SelectedValue==null)
            {
                ic = 0;
            }
            else
            {
                ic = Convert.ToInt32(idc.SelectedValue);
            }
            //проверка на существование такой строки
            if (context.address.Any(o => o.country == country.Text) && context.address.Any(o => o.city == city.Text) && context.address.Any(o => o.street == street.Text)
                && context.address.Any(o => o.house == house.Text) && context.address.Any(o => o.flat == flat.Text))
            {
                MessageBox.Show("Такой адрес уже существует", "Повторить ввод", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(country.Text))
                    error.AppendLine("Введите название страны");
                if (string.IsNullOrEmpty(city.Text))
                    error.AppendLine("Введите название города");
                if (string.IsNullOrEmpty(street.Text))
                    error.AppendLine("Введите название улицы или переулка");
                if (string.IsNullOrEmpty(house.Text) || Convert.ToInt32(house.Text)<1)
                    error.AppendLine("Введите правильное значение номера дома");
                if (string.IsNullOrEmpty(flat.Text) || Convert.ToInt32(flat.Text) < 1)
                    error.AppendLine("Введите правильное значение номера квартиры");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка при вводе данных", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                context.address.Add(new address //добавление строки в таблицу
                {
                    country = country.Text,
                    city = city.Text,
                    street = street.Text,
                    house = house.Text,
                    flat = flat.Text,
                    idp = ip,
                    idc = ic,
                });
                context.SaveChanges();//сохранение новой строки
                NavigationService.Navigate(new Adress());
            }
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Adress());
        }
        //переход по полям для ввода при помощи стрелок на клавиатуре
        private void country_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) city.Focus();
        }

        private void city_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) street.Focus();
            if (e.Key == Key.Up) country.Focus();
        }

        private void street_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) house.Focus();
            if (e.Key == Key.Up) city.Focus();
        }

        private void house_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) flat.Focus();
            if (e.Key == Key.Up) street.Focus();
        }

        private void apartament_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) idp.Focus();
            if (e.Key == Key.Up) house.Focus();
        }

        private void idp_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) idc.Focus();
            if (e.Key == Key.Up) flat.Focus();
        }

        private void idc_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up) idp.Focus();
        }

        private void country_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if ((inp < 'А' || inp > 'я') && (e.Text != "-"))
            {
                e.Handled = true;
            }
        }

        private void city_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if ((inp < 'А' || inp > 'я') && (e.Text != "-"))
            {
                e.Handled = true;
            }
        }

        private void street_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if ((inp < 'А' || inp > 'я') && (e.Text != "-"))
            {
                e.Handled = true;
            }
        }
    }
}
