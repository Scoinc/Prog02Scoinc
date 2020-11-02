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

        private void BigButton_Click(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text += " Boop";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 0;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 1;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 2;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 3;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 4;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 5;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 6;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 7;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 8;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);
            int sum = value + 9;
            sumNum.Text = "";
            sumNum.Text += sum;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            sumNum.Text = "0";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);

        }

        private void times_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);

        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(sumNum.Text);

        }
    }
}
