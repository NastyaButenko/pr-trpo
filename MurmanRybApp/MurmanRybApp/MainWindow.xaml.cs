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
using MurmanRybApp.Classes;
using MurmanRybApp.Entities;
using MurmanRybApp.Windows;

namespace MurmanRybApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = DBConnection.Connection.User.ToList();
            foreach (var u in users)
            {
                if (u.Login == LoginTextBox.Text && u.Password == Password.Password)
                {
                    DBConnection.Role = u.Role;
                    DBConnection.User = u.Login;
                }
                else { DBConnection.Role = null; }
            }

            switch (DBConnection.Role)
            {
                case null:
                    MessageBox.Show("Неверные данные!");
                    break;
                case "customer":
                    CustomerMenu CustomerMenuFrm = new CustomerMenu();
                    CustomerMenuFrm.Show();
                    this.Close();
                    break;
                case "admin":
                    AdministratorMenu AdminFrm = new AdministratorMenu();
                    AdminFrm.Show();
                    this.Close();
                    break;
            }
        }
    }
}
