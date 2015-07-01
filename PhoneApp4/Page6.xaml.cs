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
    public partial class Page5 : PhoneApplicationPage
    {
        public Page5()
        {
            InitializeComponent();
          
        }


        private void _6Rzgowska_Kurczaki_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/6rzgowska-Kurczaki.xaml", UriKind.Relative));
        }

        private void kierunek_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void _6Rzgowska_cmentarz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/6Rzgowska_cmentarz.xaml", UriKind.Relative));
        }
    }
}