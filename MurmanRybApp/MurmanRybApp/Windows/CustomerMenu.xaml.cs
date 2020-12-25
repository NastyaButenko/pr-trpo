﻿using System;
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

namespace MurmanRybApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для CustomerMenu.xaml
    /// </summary>
    public partial class CustomerMenu : Window
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void ExtiButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.DBConnection.Role = null;
            new MainWindow().Show();
            this.Close();
        }
    }
}
