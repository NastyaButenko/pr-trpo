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


namespace MurmanRybApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {
        public CustomerManagement()
        {
            InitializeComponent();

            MainDataGrid.ItemsSource = DBConnection.Connection.Customer.ToList();
        }
    }
}
