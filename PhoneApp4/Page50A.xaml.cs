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
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace PhoneApp4
{
    public partial class Page4 : PhoneApplicationPage
    {
        public Page4()
        {
            InitializeComponent();
            tb1.Text = "Kamil";
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void cos_Click(object sender, RoutedEventArgs e)
        {
           
            StreamReader oStreamReader = new StreamReader("Dane.txt");
            String dane = oStreamReader.ReadToEnd();
            String obiekty = dane.Trim(new Char[] { ']', '[' });

            string[] lines = Regex.Split(obiekty, "},");
            for (int i = 0; i < lines.Length-1; i++ )
            {
                lines[i] = lines[i] + "}";
            }

                foreach (string line in lines)
                {
                    MessageBox.Show(line);
                }
                try
                {
                    JObject oObject = JObject.Parse(lines[0]);
                    tb1.Text = "ID: " + (string)oObject["id"] +
                           "\nname: " + (string)oObject["name"] +
                           "\nsku: " + (string)oObject["sku"] +
                           "\ndescription: " + (string)oObject["description"];
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
        }

        private void cos1_Click(object sender, RoutedEventArgs e)
        {
            StreamReader oStreamReader = new StreamReader("Przystanki.txt");
            List<String> sourceList = new List<string>();

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
                    JObject oObject= JObject.Parse(lines[i]);
                    sourceList.Add("ID: " + (string)oObject["id"] +
                        "\nstop_street: " + (string)oObject["stop_street"] +
                        "\ndirection: " + (string)oObject["direction"]);
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
            llsList.ItemsSource = sourceList;
        }

        private void ls1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Rozkla
    {
        public int id { get; set; }
        public string name { get; set; }
        public string sku { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int channel { get; set; }
    }
}