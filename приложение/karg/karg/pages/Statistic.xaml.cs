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
using System.Data.SqlClient;
using System.Configuration;

namespace karg.pages
{
    /// <summary>
    /// Логика взаимодействия для Statistic.xaml
    /// </summary>
    public partial class Statistic : Page
    {
        private santoriniEntities context = new santoriniEntities();
        public Statistic()
        {
            InitializeComponent();
            string[] tablemas = { "продукты", "должности", "персонал"};
            table.ItemsSource = tablemas;

            // Форматировать диаграмму
            ChartSantorini.BackColor = System.Drawing.Color.Transparent;
            //ChartSantorini.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            //ChartSantorini.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

            //ChartSantorini.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            //ChartSantorini.BorderlineColor = System.Drawing.Color.Gray;
            //ChartSantorini.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;

            ChartSantorini.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("Default"));
            ChartSantorini.ChartAreas[0].BackColor = System.Drawing.Color.Wheat;
            

            // Добавить и форматировать заголовок
            ChartSantorini.Titles.Add("Statistic in Santorini");
            ChartSantorini.Titles[0].Font = new Font("Segoe Script", 16);
        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChartSantorini.Series.Clear();
            if (Convert.ToString(table.SelectedValue) == "продукты")
            {
                ChartSantorini.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("Mainpr")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
                });
                ChartSantorini.DataSource = context.product.ToList();
                ChartSantorini.Series[0].XValueMember = "name";
                ChartSantorini.Series[0].YValueMembers = "price";
            }
            if (Convert.ToString(table.SelectedValue) == "должности")
            {
                ChartSantorini.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("Mainw")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                });
                ChartSantorini.DataSource = context.work.ToList();
                ChartSantorini.Series[0].XValueMember = "position";
                ChartSantorini.Series[0].YValueMembers = "salary";
            }
            if (Convert.ToString(table.SelectedValue) == "персонал")
            {
                ChartSantorini.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("Mainpp")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                });
                SqlConnection conn = new SqlConnection(context.Database.Connection.ConnectionString);
                string sql = "SELECT surname, salary FROM work, personal WHERE work.ids = personal.ids";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                ChartSantorini.DataSource = reader;
                ChartSantorini.Series[0].Points.DataBindXY(reader, "surname", reader, "salary");
                ChartSantorini.DataBind();
                reader.Close();
                conn.Close();
            }
        }
    }
}
