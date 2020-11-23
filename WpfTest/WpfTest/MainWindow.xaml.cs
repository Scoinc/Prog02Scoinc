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

namespace WpfTest
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
        
        //All of this could be simplified by having every button be inOutput.Text += xButton.Content but whatever,
        //it doesn't even cut down on rows.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            inOutput.Text += 9;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            inOutput.Text = "";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            inOutput.Text += "+";

        }

        private void times_Click(object sender, RoutedEventArgs e)
        {
            inOutput.Text += "*";

        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            inOutput.Text += "/";

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            inOutput.Text += "-";

        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            string text = inOutput.Text;
            string[] splitText;
            int r;
            int val1;
            int val2;
            int val3;

            //Does not handle negative numbers or several equations unless '=' is pressed between each equation
            for (int i = 0; i < inOutput.Text.Length; i++)
            {
                char[] numArray = text.ToCharArray();

                if ( numArray[i] == '+')
                {
                    splitText = text.Split('+');
                    val1 = int.Parse(splitText[0]);
                    val2 = int.Parse(splitText[1]);
                    val3 = val1 + val2;
                    inOutput.Text = Convert.ToString(val3);
                }

                else if (numArray[i] == '-')
                {
                    splitText = text.Split('-');
                    val1 = int.Parse(splitText[0]);
                    val2 = int.Parse(splitText[1]);
                    val3 = val1 - val2;
                    inOutput.Text = Convert.ToString(val3);
                }

                else if (numArray[i] == '*')
                {
                    splitText = text.Split('*');
                    val1 = int.Parse(splitText[0]);
                    val2 = int.Parse(splitText[1]);
                    val3 = val1 * val2;
                    inOutput.Text = Convert.ToString(val3);
                }

                else if (numArray[i] == '/')
                {
                    splitText = text.Split('/');
                    val1 = int.Parse(splitText[0]);
                    val2 = int.Parse(splitText[1]);
                    val3 = val1 / val2;
                    inOutput.Text = Convert.ToString(val3);
                }
            }
        }
    }
}
