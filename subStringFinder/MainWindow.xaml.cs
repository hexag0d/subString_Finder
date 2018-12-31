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

namespace subStringFinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*app by Clark*/

        static int posInt;

        static int lenInt;

        private void StringTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                subStrTextBox.Text = stringTextBox.Text.Substring(posInt, lenInt);
            }
            catch (Exception ex)
            {
                statusTextBox.Text = ex.ToString();
            }
        }

        private void PosTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                posInt = Int32.Parse(posTextBox.Text);

            }
            catch (Exception ex)
            {
                statusTextBox.Text = ex.ToString();
                return;
            }
            try
            {
                subStrTextBox.Text = stringTextBox.Text.Substring(posInt, lenInt);


            }
            catch (Exception ex)
            {
                statusTextBox.Text = ex.ToString();
                return;
            }
            subStrTextBox.Text = stringTextBox.Text.Substring(posInt, lenInt);

        }

        private void LengthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                lenInt = Int32.Parse(lengthTextBox.Text);
                subStrTextBox.Text = stringTextBox.Text.Substring(posInt, lenInt);

            }
            catch (Exception ex)
            {
                statusTextBox.Text = ex.ToString();
                return;
            }
            try
            {
                subStrTextBox.Text = stringTextBox.Text.Substring(posInt, lenInt);


            }
            catch (Exception ex)
            {
                statusTextBox.Text = ex.ToString();
                return;
            }
            subStrTextBox.Text = stringTextBox.Text.Substring(posInt, lenInt);

        }
    }
}
