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
using System.Windows.Shapes;
using MurmanRybApp.Classes;
using MurmanRybApp.Entities;
using MurmanRybApp.Windows;

namespace MurmanRybApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для StoreManagement.xaml
    /// </summary>
    public partial class StoreManagement : Window
    {
        public StoreManagement()
        {
            InitializeComponent();

            MainDataGrid.ItemsSource = DBConnection.Connection.Assortiment.ToList();

            MyDataGrid.DataContext = DBConnection.Connection.Assortiment.ToList().First();
        }

        private void MainDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            MyDataGrid.DataContext = null;
            MyDataGrid.DataContext = MainDataGrid.SelectedItem as Assortiment;

        }
    }
}
