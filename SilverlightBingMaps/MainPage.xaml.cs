using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl;

namespace SilverlightBingMaps
{
    public partial class MainPage : UserControl
    {
        public List<Customer> Customers { get; set; }

        public MainPage()
        {
            InitializeComponent();
            //http://blog.credera.com/topic/technology-solutions/business-intelligence/building-interactive-maps-with-silverlight-and-bing-maps-2/

            MyMap.Center = new Location(39.226, -99.829);
            MyMap.ZoomLevel = 5;

            Customers = new List<Customer>();
            Customers.Add(new Customer("Bill", "PC", 37, -79));
            Customers.Add(new Customer("Steve", "Mac", 30, -90));
            Customers.Add(new Customer("Maria", "PC", 45, -92));
            Customers.Add(new Customer("Andy", "Mac", 45, -108));
            Customers.Add(new Customer("Tiffany", "PC", 40, -118));
            Customers.Add(new Customer("Ryan", "PC", 35, -102));


        }

        private void btnLoadCustomers_Click(object sender, RoutedEventArgs e)
        {
            MyMap.Children.Clear();
            ComboBoxItem item = cbCompType.SelectedItem as ComboBoxItem;
            string compType = item.Content.ToString();

            foreach (Customer cust in Customers)
            {
                if (cust.ComputerType == compType)
                    MyMap.Children.Add(cust);
                else if (compType == "-All-")
                    MyMap.Children.Add(cust);
            }

        }
    }
}
