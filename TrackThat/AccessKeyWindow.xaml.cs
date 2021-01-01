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
using System.Windows.Shapes;

namespace TrackThat
{
    /// <summary>
    /// Interaction logic for AccessKeyWindow.xaml
    /// </summary>
    public partial class AccessKeyWindow : Window
    {
        private SetKey setKey;

        public AccessKeyWindow(SetKey sk)
        {
            setKey = sk;
            InitializeComponent();
        }

        private void uxSubmitBtn_Click(object sender, EventArgs e)
        {
            string key = uxAccessKeyTxt.Text;
            if (key == "") MessageBox.Show("Enter an access key to continue");
            else
            {
                bool result = setKey(key);
                if (!result) MessageBox.Show("Key provided was invalid. Enter a key to continue");
                else { this.Close(); }
            }
        }
    }
}
