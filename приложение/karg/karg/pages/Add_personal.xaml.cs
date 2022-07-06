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
    /// Логика взаимодействия для Add_personal.xaml
    /// </summary>
    public partial class Add_personal : Page
    {
        santoriniEntities context;
        public Add_personal()
        {
            InitializeComponent();
            context = new santoriniEntities();
            w.ItemsSource = context.work.ToList();
            idc.ItemsSource = context.cafe.ToList();
        }

        private void ButtonSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            //проверка на существование такой строки
            if (context.personal.Any(o => o.surname == surname.Text) && context.personal.Any(o => o.name == name.Text)
                && context.personal.Any(o => o.lastname == lastname.Text) && context.personal.Any(o => Convert.ToInt32(o.seria_pasport) == Convert.ToInt32(seria.Text))
                && context.personal.Any(o => Convert.ToInt32(o.number_pasport) == Convert.ToInt32(number.Text)) && context.personal.Any(o => o.birth == Convert.ToDateTime(dat.Text)))
            {
                MessageBox.Show("Такой официант уже существует", "Повторить ввод", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(name.Text))
                    error.AppendLine("Введите имя");
                if (string.IsNullOrEmpty(surname.Text))
                    error.AppendLine("Введите фамилию");
                if (string.IsNullOrEmpty(lastname.Text))
                    error.AppendLine("Введите отчество (второе имя)");
                if (string.IsNullOrEmpty(seria.Text) || Convert.ToInt32(seria.Text) < 0)
                    error.AppendLine("Введите верную серию");
                if (string.IsNullOrEmpty(number.Text) || Convert.ToInt32(number.Text) < 0)
                    error.AppendLine("Введите верный номер");
                DateTime date = DateTime.Now.Date;
                if (string.IsNullOrEmpty(dat.Text) || Convert.ToDateTime(dat.Text) > date)
                    error.AppendLine("Введите верную дату");
                if (w.SelectedValue == null)
                    error.AppendLine("Выберите зарплату");
                if (idc.SelectedValue == null)
                    error.AppendLine("Выберите наименование кафе");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка при вводе данных", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                context.personal.Add(new personal //добавление строки в таблицу
                {
                    surname = surname.Text,
                    name = name.Text,
                    lastname = lastname.Text,
                    birth = Convert.ToDateTime(dat.Text),
                    seria_pasport = Convert.ToInt32(seria.Text),
                    number_pasport = Convert.ToInt32(number.Text),
                    ids = Convert.ToInt32(w.SelectedValue),
                    idc = Convert.ToInt32(idc.SelectedValue),
                });
                context.SaveChanges();//сохранение новой строки
                NavigationService.Navigate(new Personal());
            }
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Personal());
        }
        //переход по полям для ввода при помощи стрелок на клавиатуре
        private void surname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) name.Focus();
        }

        private void name_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) lastname.Focus();
            if (e.Key == Key.Up) surname.Focus();
        }

        private void lastname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) dat.Focus();
            if (e.Key == Key.Up) name.Focus();
        }

        private void dat_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) seria.Focus();
            if (e.Key == Key.Up) lastname.Focus();
        }

        private void seria_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) number.Focus();
            if (e.Key == Key.Up) dat.Focus();
        }

        private void number_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) w.Focus();
            if (e.Key == Key.Up) seria.Focus();
        }

        private void work_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) idc.Focus();
            if (e.Key == Key.Up) number.Focus();
        }

        private void idc_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up) w.Focus();
        }

        private void surname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if ((inp < 'А' || inp > 'я') && (e.Text != "-"))
            {
                e.Handled = true;
            }
        }

        private void name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if ((inp < 'А' || inp > 'я') && (e.Text != "-"))
            {
                e.Handled = true;
            }
        }

        private void lastname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if ((inp < 'А' || inp > 'я') && (e.Text != "-"))
            {
                e.Handled = true;
            }
        }
    }
}
