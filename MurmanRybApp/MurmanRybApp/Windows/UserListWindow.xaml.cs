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
    /// Логика взаимодействия для UserListWindow.xaml
    /// </summary>
    public partial class UserListWindow : Window
    {
        public UserListWindow()
        {
            InitializeComponent();

            RoleComboBox.ItemsSource = new List<string>() { "Не выбрано", "Администратор", "Заказчик" };

            MainDataGrid.ItemsSource = DBConnection.Connection.User.ToList();
        }

        private void RoleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(RoleComboBox.SelectedItem.ToString() == "Не выбрано") 
            {
                MainDataGrid.ItemsSource = DBConnection.Connection.User.ToList();
            }
            else if(RoleComboBox.SelectedItem.ToString() == "Администратор") 
            {
                MainDataGrid.ItemsSource = DBConnection.Connection.User.ToList().Where(u => u.Role == "admin").ToList();
            }
            else 
            { 
                MainDataGrid.ItemsSource = DBConnection.Connection.User.ToList().Where(u => u.Role == "customer").ToList();            
            }
        }
    }
}
