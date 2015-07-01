using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json.Linq;
using System.IO;


namespace PhoneApp4
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Trasa_Click(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Rozklad.xaml", UriKind.Relative));
        }

        private void _50_Click(object sender, RoutedEventArgs e)
        {
            HttpWebResponse oHttpWebResponse = null;
            StreamReader oStreamReader = null;
            try
            {
               // HttpWebRequest oHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.deanclatworthy.com/imdb/?q=The+Green+Mile");
                //oHttpWebRequest.Method = "GET";
                //oHttpWebResponse = (HttpWebResponse)oHttpWebRequest.GetResponse();
                oStreamReader = new StreamReader(oHttpWebResponse.GetResponseStream());
                JObject oObject = JObject.Parse(oStreamReader.ReadToEnd());
                Console.WriteLine("ID: " + (string)oObject["id"] +
                    "\nNazwa filmu: " + (string)oObject["title"] +
                    "\nOcena: " + (string)oObject["rating"]);
            }
            catch (Exception oException)
            {
                Console.WriteLine("Błąd: " + oException.Message);
            }
            finally
            {
                if (null != oStreamReader)
                {
                    oStreamReader.Close();
                }
                if (null != oHttpWebResponse)
                {
                    oHttpWebResponse.Close();
                }
            }
        }

        private void _50A_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page50A.xaml", UriKind.Relative));
            

        }
    }
}