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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double ch, rez;
       
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 0;
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 1;
        }
        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 2;
        }
        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 3;
        }
        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 4;
        }
        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 5;
        }
        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 6;
        }
        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 7;
        }
        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 8;
        }
        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text +=9;
        }

        private void button_equal_Click(object sender, RoutedEventArgs e)
        {
            calculate();
           
            textBox.Text += " ";
        }

        private void button_C_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }

        private void button_comma_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += ",";
        }

        private void button_multi_Click(object sender, RoutedEventArgs e)
        {
            ch = double.Parse(textBox.Text);
            textBox.Clear();
            count = 4;
           //label.Content = ch.ToString() + "*";
           
        }

        private void button_fraction_Click(object sender, RoutedEventArgs e)
        {
            ch = double.Parse(textBox.Text);
           textBox.Clear();
            count = 3;
          // label.Content = ch.ToString() + "/";
            
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            ch = double.Parse(textBox.Text);
            textBox.Clear();
            count = 1;
           //label.Content += ch.ToString() + "+";
          
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            ch = double.Parse(textBox.Text);
            textBox.Clear();
            count = 2;
           // label.Content = ch.ToString()+"-";
           
        }
        private void calculate()
        {
            switch(count)
            {
                case 1:
                    
                   rez = ch + double.Parse(textBox.Text);  
                    textBox.Text ="="+ rez.ToString();
                    break;
                case 2:
                    rez = ch - double.Parse(textBox.Text);
                    textBox.Text ="="+rez.ToString();
                    break;
                case 3:
                    rez = ch / double.Parse(textBox.Text);
                    textBox.Text ="="+rez.ToString();
                    break;
                case 4:
                    rez = ch * double.Parse(textBox.Text);
                    textBox.Text ="="+ rez.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
