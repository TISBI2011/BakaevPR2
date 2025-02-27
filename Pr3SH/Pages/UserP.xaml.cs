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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BakaevPR2.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserP.xaml
    /// </summary>
    public partial class UserP : Page
    {
        public UserP()
        {
            InitializeComponent();
            DishListDG.ItemsSource = App.DB.furniture.ToList();
        }
        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddP());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LogInP());
        }
    }
}
