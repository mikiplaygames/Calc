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

namespace projek
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int x, y;
        bool isXSet = false;
        bool isYSet = false;
        bool setB = false;

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            count(0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            count(1);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            count(2);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            count(3);
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            count(4);
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            count(5);
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            count(6);
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            count(7);
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            count(8);
        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            count(9);
        }

        private void count(int numbr)
        {
            if (!setB)
            {
                string meta = x.ToString() + x.ToString();
                x = int.Parse(meta);
                isXSet = true;
                skladiki.Text = "x = " + x.ToString();
            }
            else
            {
                string meta = y.ToString() + y.ToString();
                y = int.Parse(meta);
                isYSet = true;
                skladiki.Text = skladiki.Text + "\ny = " + y.ToString();
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            znak.Text = "+";
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x + y;
                wyink.Text = ans.ToString();
                isXSet = false;
                isYSet = false;
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {

            znak.Text = "-";
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x - y;
                wyink.Text = ans.ToString();
                isXSet = false;
                isYSet = false;
            }
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            znak.Text = "*";
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x * y;
                wyink.Text = ans.ToString();
                isXSet = false;
                isYSet = false;
            }
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            znak.Text = "/";
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x / y;
                wyink.Text = ans.ToString();
                isXSet = false;
                isYSet = false;
            }
        }
        private void log_Click(object sender, RoutedEventArgs e)
        {
            znak.Text = "log(x)";
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                double logX = Math.Log(x);
                double logY = Math.Log(y);
                double logXY = Math.Log(x,y);
                double logYX = Math.Log(y,x);
                wyink.Text = $"{logX.ToString()} + 'log z: {x}' \n{logY.ToString()} + 'log z: {y}' \n{logXY.ToString()} + 'log z: {x} stopnia {y}' \n{logYX.ToString()} + 'log z: {y} stopnia {x}' \n";
                isXSet = false;
                isYSet = false;
            }
        }

        private void change(object sender, RoutedEventArgs e)
        {
            setB = !setB;
            changebt.Content = !setB ? "A" : "B";
        }

        private void pot_Click(object sender, RoutedEventArgs e)
        {
            znak.Text = "^";
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                double ans = Math.Pow(x,y);
                wyink.Text = ans.ToString();
                isXSet = false;
                isYSet = false;
            }
        }
    }
}
