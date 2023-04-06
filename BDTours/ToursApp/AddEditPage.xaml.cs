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

namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Hotel _curentHotel = new Hotel();
        public AddEditPage(Hotel selectedHotel)
        {
            InitializeComponent();

            if (selectedHotel != null)
            {
                _curentHotel = selectedHotel;
            }

            DataContext = _curentHotel;
            ComboCountries.ItemsSource = tours21ISMazhorovEntities.GetContext().Country.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_curentHotel.Name))
                errors.AppendLine("Укажите название отеля:");
            if (_curentHotel.CountOfStars < 1 || _curentHotel.CountOfStars > 5)
                errors.AppendLine("Количество звёзд от 1 до 5");
            if (_curentHotel.Country == null)
                errors.AppendLine("Выберите страну");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_curentHotel.Id == 0)
                tours21ISMazhorovEntities.GetContext().Hotel.Add(_curentHotel);


            try
            {
                tours21ISMazhorovEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manger.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
