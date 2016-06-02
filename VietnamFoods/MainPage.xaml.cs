using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using VietnamFoods.Resources;

namespace VietnamFoods
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

      

        private void Go_MainApp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/MainApp.xaml", UriKind.RelativeOrAbsolute));
        }

        
    }
}