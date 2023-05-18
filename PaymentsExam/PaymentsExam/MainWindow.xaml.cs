using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaymentsExam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PaymentBaseEntities _context = new PaymentBaseEntities();

        public MainWindow()
        {
            InitializeComponent();
            ChartPayment.ChartAreas.Add(new ChartArea("Main"));

            var currentSeries = new Series("Payment")
            {
                IsValueShownAsLabel = true
            };
            ChartPayment.Series.Add(currentSeries);

            ComboUser.ItemsSource = _context.Users.ToList();
            ComboChartTypes.ItemsSource = Enum.GetValues(typeof(SeriesChartType));
        }
        private void UpdateChart(object sender, SelectionChangedEventArgs e)
        {
            if (ComboUser.SelectedItem is User currentUser &&
                    ComboChartTypes.SelectedItem is SeriesChartType currentType)
            {
                Series currentSeries = ChartPayment.Series.FirstOrDefault();
                currentSeries.ChartType = currentType;
                currentSeries.Points.Clear();

                var categoriesList = _context.Categories.ToList();
                foreach (var category in categoriesList)
                {
                    currentSeries.Points.AddXY(category.Name, 
                        _context.Payments.ToList().Where(p=>p.User == currentUser
                        && p.Category == category).Sum(p => p.Price * p.Num));
                }
            }
        }


    }
}
