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

namespace MurmanRybApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdministratorMenu.xaml
    /// </summary>
    public partial class AdministratorMenu : Window
    {
        public AdministratorMenu()
        {
            InitializeComponent();
        }

        private void ExtiButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.DBConnection.Role = null;
            new MainWindow().Show();
            this.Close();
        }

        private void UserListButton_Click(object sender, RoutedEventArgs e)
        {
            new UserListWindow().Show();
            this.Close();
        }

        private void StoreManagementButton_Click(object sender, RoutedEventArgs e)
        {
            new StoreManagement().Show();
            this.Close();
        }
    }
}
