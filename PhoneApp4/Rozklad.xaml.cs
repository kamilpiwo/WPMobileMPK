using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp4
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Trasa_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/rozklad.xaml", UriKind.Relative));
        }

        private void Button_Autobus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageAutobusy.xaml", UriKind.Relative));
        }

        private void Button_Tramwaje_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageTrawaje.xaml", UriKind.Relative));
        }
    }
}