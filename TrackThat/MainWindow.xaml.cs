using System;
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
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrackThat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            //update = uv;
            InitializeComponent();
        }

        private void uxGetInfo_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void uxAddPackage_Click(object sender, RoutedEventArgs e)
        {

        }

        private Shipment ExtractUserInput()
        {
            string trackingNo = uxTrackingTxt.Text;
            string carrier = "";
            if (uxUpsRadio.IsChecked == true) carrier = "ups";
            else if (uxUspsRadio.IsChecked == true) carrier = "usps";
            else if (uxFedExRadio.IsChecked == true) carrier = "fedex";
            return new Shipment(carrier, trackingNo);
        }
    }
}
