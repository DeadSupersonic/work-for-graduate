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

namespace karg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //подключение к базе данных
        santoriniEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new santoriniEntities();
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        { 
            //осуществляем вход в приложение по логину и паролю, которые получаем из базы данных
            string log = login.Text;
            string pass = password.Password;
            if (context.personal.Where(z => z.surname.ToLower() == log).Where(z => z.work.position == "администратор").Count() != 0 && (pass == "admin"))
            {
                //переход на окно главная
                Window z = new главная();
                this.Close();
                z.ShowDialog();
            }
            else
            {
                //если логин или пароль неверные, то переход не осуществится и вылетит сообщение об ошибке
                MessageBox.Show("Данные введены неверно", "OK", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        //переход по полям для ввода при помощи стрелок на клавиатуре
        private void Login_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) password.Focus();
        }

        private void Password_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up) login.Focus();
            if (e.Key == Key.Enter)
            {
                string log = login.Text;
                string pass = password.Password;
                if (context.personal.Where(z => z.surname.ToLower() == log).Where(z => z.work.position == "администратор").Count() != 0 && (pass == "admin"))
                {
                    //переход на окно главная
                    Window z = new главная();
                    this.Close();
                    z.ShowDialog();
                }
                else
                {
                    //если логин или пароль неверные, то переход не осуществится и вылетит сообщение об ошибке
                    MessageBox.Show("Данные введены неверно", "OK", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Users\zorin\OneDrive\Рабочий стол\диплом\Диплом.Зорина (1).docx");
            }
            catch
            {
                MessageBox.Show("Документ с таким именем не найден", "Документ с таким именем не найден", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
