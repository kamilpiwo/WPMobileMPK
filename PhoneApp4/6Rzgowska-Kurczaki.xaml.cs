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
using System.Text.RegularExpressions;

namespace PhoneApp4
{
    public partial class Page7 : PhoneApplicationPage
    {
        public Page7()
        {
            InitializeComponent();
            StreamReader oStreamReader = new StreamReader("Godziny.txt");
            List<String> sourceList = new List<string>();
            sourceList.Add("kierunek -> Strykowska");
            String dane = oStreamReader.ReadToEnd();
            String obiekty = dane.Trim(new Char[] { ']', '[' });


            string[] lines = Regex.Split(obiekty, "},");
            for (int i = 0; i < lines.Length - 1; i++)
            {
                lines[i] = lines[i] + "}";
            }


            //foreach (string line in lines)
            //{
            //    MessageBox.Show(line);
            // }
            try
            {

                for (int i = 0; i < lines.Length; i++)
                {
                    JObject oObject = JObject.Parse(lines[i]);
                    sourceList.Add("Godzina: " + (string)oObject["Godzina"] +
                        "\n: " + (string)oObject["Minuty"]);
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
            lista.ItemsSource = sourceList;

        
        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ScrollBar_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}