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
    /// Логика взаимодействия для Add_cafe.xaml
    /// </summary>
    public partial class Add_cafe : Page
    {
        santoriniEntities context;
        public Add_cafe()
        {
            InitializeComponent();
            context = new santoriniEntities();
        }

        private void ButtonSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            //проверка на существование такой строки
            if (context.cafe.Any(o => o.name == name.Text))
            {
                MessageBox.Show("Такое кафе уже существует", "Повторить ввод", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(name.Text))
                    error.AppendLine("Введите название кафе");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка при вводе данных", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                context.cafe.Add(new cafe //добавление строки в таблицу
                {
                    name = name.Text,
                });
                context.SaveChanges();//сохранение новой строки
                NavigationService.Navigate(new Cafe());
            }
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cafe());
        }
    }
}
