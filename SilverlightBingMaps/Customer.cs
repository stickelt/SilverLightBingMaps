using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl;

namespace SilverlightBingMaps
{
    public class Customer : Pushpin
    {
        public string CustomerName { get; set; }
        public string ComputerType { get; set; }

        public Customer(string name, string type, double lat, double lon)
        {
            CustomerName = name;
            ComputerType = type;
            Location = new Location(lat, lon);
            ToolTipService.SetToolTip(this, name);
            if (type == "Mac")
            {
                Background = new SolidColorBrush(Colors.Blue);
                
            }
            else
            {
                Background = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
