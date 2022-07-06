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
    /// Логика взаимодействия для Add_work.xaml
    /// </summary>
    public partial class Add_work : Page
    {
        santoriniEntities context;
        public Add_work()
        {
            InitializeComponent();
            context = new santoriniEntities();
            string[] mas = { "низкая квалификация", "удовлетворительная квалификация", "средняя квалификация", "хорошая квалификация", "высокая квалификация" };
            qua.ItemsSource = mas;
            string[] mas1 = { "уборщик", "официант", "повар", "администратор", "доставщик", "бармен", "кассир" };
            name.ItemsSource = mas1;
            string[] mas2 = { "низкая эффективность", "удовлетворительная эффективность", "средняя эффективность", "хорошая эффективность", "высокая эффективность" };
            ef.ItemsSource = mas2;
        }

        private void ButtonSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrEmpty(exp.Text) || Convert.ToInt32(exp.Text)<0)
                error.AppendLine("Введите верный стаж");
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка при вводе данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            int ex = Convert.ToInt32(exp.Text);
            int sa=0;
            //вычисляем зарплату
            //прибавляем зарплату по должности
            if(Convert.ToString(name.SelectedValue) == "уборщик")
            {
                sa = sa + 7000;
            }
            else if (Convert.ToString(name.SelectedValue) == "официант")
            {
                sa = sa + 15000;
            }
            else if (Convert.ToString(name.SelectedValue) == "повар")
            {
                sa = sa + 25000;
            }
            else if (Convert.ToString(name.SelectedValue) == "администратор")
            {
                sa = sa + 40000;
            }
            else if (Convert.ToString(name.SelectedValue) == "доставщик")
            {
                sa = sa + 20000;
            }
            else if (Convert.ToString(name.SelectedValue) == "бармен")
            {
                sa = sa + 20000;
            }
            else if (Convert.ToString(name.SelectedValue) == "кассир")
            {
                sa = sa + 20000;
            }
            //прибавляем надбавки за квалификацию
            if (Convert.ToString(qua.SelectedValue) == "низкая квалификация")
            {
                sa = sa + 1000;
            }
            else if(Convert.ToString(qua.SelectedValue) == "удовлетворительная квалификация")
            {
                sa = sa + 2000;
            }
            else if (Convert.ToString(qua.SelectedValue) == "средняя квалификация")
            {
                sa = sa + 3000;
            }
            else if (Convert.ToString(qua.SelectedValue) == "хорошая квалификация")
            {
                sa = sa + 4000;
            }
            else if (Convert.ToString(qua.SelectedValue) == "высокая квалификация")
            {
                sa = sa + 5000;
            }
            //прибавляем надбавки заэффективность
            if (Convert.ToString(ef.SelectedValue) == "низкая эффективность")
            {
                sa = sa + 1000;
            }
            else if (Convert.ToString(ef.SelectedValue) == "удовлетворительная эффективность")
            {
                sa = sa + 2000;
            }
            else if (Convert.ToString(ef.SelectedValue) == "средняя эффективность")
            {
                sa = sa + 3000;
            }
            else if (Convert.ToString(ef.SelectedValue) == "хорошая эффективность")
            {
                sa = sa + 4000;
            }
            else if (Convert.ToString(ef.SelectedValue) == "высокая эффективность")
            {
                sa = sa + 5000;
            }
            int z = 0;
            if (ex % 5 == z)
            {
                //прибавляем надбавки за стаж
                for (int i = 5; i <= ex; i=i+5)
                {
                    sa = sa + 1000;
                }
            }
            //проверка на существование такой строки
            if (context.work.Any(o => o.position == name.Text) && context.work.Any(o => o.salary == sa))
            {
                MessageBox.Show("Такая должность уже существует", "Повторить ввод", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (name.SelectedValue == null)
                    error.AppendLine("Выберите должность");
                if (qua.SelectedValue == null)
                    error.AppendLine("Выберите квалификацию");
                if (ef.SelectedValue == null)
                    error.AppendLine("Выберите эффективность");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка при вводе данных", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                context.work.Add(new work //добавление строки в таблицу
                {
                    position = Convert.ToString(name.SelectedValue),
                    qualification=Convert.ToString(qua.SelectedValue),
                    efficiency= Convert.ToString(ef.SelectedValue),
                    experience=exp.Text,
                    salary=sa,
                });
                context.SaveChanges();//сохранение новой строки
                NavigationService.Navigate(new Work());
            }
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Work());
        }
        //переход по полям для ввода при помощи стрелок на клавиатуре
        private void name_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) qua.Focus();
        }

        private void qua_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) ef.Focus();
            if (e.Key == Key.Up) name.Focus();
        }

        private void ef_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down) exp.Focus();
            if (e.Key == Key.Up) qua.Focus();
        }

        private void exp_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up) ef.Focus();
        }
    }
}
