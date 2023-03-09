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
using RoomLibrary;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room = new Room();
        LivingRoom livingRoom = new LivingRoom();
        Office office = new Office();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
        }
        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            room.RoomLength = Convert.ToDouble(TBLenghtR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
        }
        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            office.RoomLength = Convert.ToDouble(TBLenghtO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
        }
        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
           // ListRooms.Content = "";
            ListRooms.Content += room.Info() + "\n";
            ListRooms.Content += livingRoom.Info() + "\n";
            ListRooms.Content += office.Info() + "\n";
        }

        private void TBLenghtO_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBWidthO_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBNumS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBLenghtR_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBWidthR_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBNumW_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBWidthL_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BGetList_Copy_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
        }

        private void BGetList_Copy2_Click(object sender, RoutedEventArgs e)
        {
            TBLenghtO.Clear();
            TBWidthO.Clear();
            TBNumS.Clear();
        }

        private void BGetList_Copy3_Click(object sender, RoutedEventArgs e)
        {
            TBLengthL.Clear();
            TBWidthL.Clear();
            TBNumW.Clear();
        }

        private void BGetList_Copy1_Click(object sender, RoutedEventArgs e)
        {
            TBLenghtR.Clear();
            TBWidthR.Clear();   
        }
    }
    
}

       