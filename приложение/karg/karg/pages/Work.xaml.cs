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
    /// Логика взаимодействия для Work.xaml
    /// </summary>
    public partial class Work : Page
    {
        santoriniEntities context;
        public Work()
        {
            InitializeComponent();
            context = new santoriniEntities();
            //вывод данных таблицы официант в таблицу на странице
            DataGridRegistration.ItemsSource = context.work.ToList();
            choose.ItemsSource = context.work.ToList();
            string[] mas = { "низкая квалификация", "удовлетворительная квалификация", "средняя квалификация", "хорошая квалификация", "высокая квалификация" };
            qua.ItemsSource = mas;
            string[] mas1 = { "уборщик", "официант", "повар", "администратор", "доставщик", "бармен", "кассир" };
            name.ItemsSource = mas1;
            string[] mas2 = { "низкая эффективность", "удовлетворительная эффективность", "средняя эффективность", "хорошая эффективность", "высокая эффективность" };
            ef.ItemsSource = mas2;
        }

        private void ButtonAdd_click(object sender, RoutedEventArgs e)
        {
            //переход другую на страницу с целью добавления новой строки
            NavigationService.Navigate(new Add_work());
            DataGridRegistration.ItemsSource = context.work.ToList();
        }
        private void ButtonDel_click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as work;
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
                    context.work.Remove(r);
                    context.SaveChanges();
                    DataGridRegistration.ItemsSource = context.work.ToList();
                }
                catch
                {
                    MessageBox.Show("На этой должности ещё есть сотрудники", "Отменить удаление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ButtonCh_Click(object sender, RoutedEventArgs e)
        {
            //проверка на то, выбрали ли строку
            var r = DataGridRegistration.SelectedItem as work;
            if (r == null)
            {
                MessageBox.Show("Не были выбраны данные для изменения", "Изменить", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                int ex = Convert.ToInt32(r.experience);
                int sa = 0;
                //вычисляем зарплату
                //прибавляем зарплату по должности
                if (Convert.ToString(r.position) == "уборщик")
                {
                    sa = sa + 7000;
                }
                else if (Convert.ToString(r.position) == "официант")
                {
                    sa = sa + 15000;
                }
                else if (Convert.ToString(r.position) == "повар")
                {
                    sa = sa + 25000;
                }
                else if (Convert.ToString(r.position) == "администратор")
                {
                    sa = sa + 40000;
                }
                else if (Convert.ToString(r.position) == "доставщик")
                {
                    sa = sa + 20000;
                }
                else if (Convert.ToString(r.position) == "бармен")
                {
                    sa = sa + 20000;
                }
                else if (Convert.ToString(r.position) == "кассир")
                {
                    sa = sa + 20000;
                }
                //прибавляем надбавки за квалификацию
                if (Convert.ToString(r.qualification) == "низкая квалификация")
                {
                    sa = sa + 1000;
                }
                else if (Convert.ToString(r.qualification) == "удовлетворительная квалификация")
                {
                    sa = sa + 2000;
                }
                else if (Convert.ToString(r.qualification) == "средняя квалификация")
                {
                    sa = sa + 3000;
                }
                else if (Convert.ToString(r.qualification) == "хорошая квалификация")
                {
                    sa = sa + 4000;
                }
                else if (Convert.ToString(r.qualification) == "высокая квалификация")
                {
                    sa = sa + 5000;
                }
                //прибавляем надбавки заэффективность
                if (Convert.ToString(r.efficiency) == "низкая эффективность")
                {
                    sa = sa + 1000;
                }
                else if (Convert.ToString(r.efficiency) == "удовлетворительная эффективность")
                {
                    sa = sa + 2000;
                }
                else if (Convert.ToString(r.efficiency) == "средняя эффективность")
                {
                    sa = sa + 3000;
                }
                else if (Convert.ToString(r.efficiency) == "хорошая эффективность")
                {
                    sa = sa + 4000;
                }
                else if (Convert.ToString(r.efficiency) == "высокая эффективность")
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
                r.salary = sa;
                //изменение строки
                DataGridRegistration.DataContext = context.SaveChanges();
                NavigationService.Navigate(new Work());
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (search.Text != null)
            {
                DataGridRegistration.ItemsSource = context.work.Where(z => z.position.ToString().Contains(search.Text.ToLower())).ToList();
            }
            else if (string.IsNullOrWhiteSpace(search.Text))
            {
                NavigationService.Navigate(new Work());
            }
        }

        private void choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sa = Convert.ToInt32(choose.SelectedValue);
            DataGridRegistration.ItemsSource = context.work.Where(z => z.salary == sa).ToList();
        }
    }
}
