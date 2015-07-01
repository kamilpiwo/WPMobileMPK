using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace PhoneApp4
{
    public partial class Page8 : PhoneApplicationPage
    {
        public Page8()
        {
            InitializeComponent();
            
            StreamReader oStreamReader = new StreamReader("Godziny.txt");
            StreamReader oStreamReader1 = new StreamReader("Godziny1.txt");

            List<String> sourceList = new List<string>();
            List<String> sourceList1 = new List<string>();
            sourceList.Add("kierunek -> Strykowska");
            sourceList1.Add("kierunek -> Kurczaki");

            String dane = oStreamReader.ReadToEnd();
            String dane1 = oStreamReader1.ReadToEnd();
            String obiekty = dane.Trim(new Char[] { ']', '[' });
            String obiekty1 = dane1.Trim(new Char[] { ']', '[' });

            string[] lines = Regex.Split(obiekty, "},");
            string[] lines1 = Regex.Split(obiekty1, "},");
            
            for (int i = 0; i < lines.Length - 1; i++)
            {
                lines[i] = lines[i] + "}";
                lines1[i] = lines1[i] + "}";
            }

            try
            {

                for (int i = 0; i < lines.Length; i++)
                {
                    JObject oObject = JObject.Parse(lines[i]);
                    sourceList.Add("Godzina: " + (string)oObject["Godzina"] +
                        "\n: " + (string)oObject["Minuty"]);
                    JObject oObject1 = JObject.Parse(lines1[i]);
                    sourceList1.Add("Godzina: " + (string)oObject1["Godzina"] +
                        "\n: " + (string)oObject1["Minuty"]);
                }
            }
            catch (Exception oException)
            {
                MessageBox.Show("Błąd: " + oException.Message);
            }
            finally
            {
                if (null != oStreamReader)
                {
                    oStreamReader.Close();
                }
            }
            lista.ItemsSource =  sourceList;
            lista_1.ItemsSource = sourceList1;
        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lista_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}