using System;
using System.Windows;

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
        char znak;

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            Count(0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Count(1);
        }
        
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Count(2);
        }
        
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Count(3);
        }
        
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Count(4);
        }
        
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Count(5);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Count(6);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Count(7);
        }
        
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Count(8);
        }
        
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Count(9);
        }

        private void Count(int number)
        {
            if (!setB)
            {
                string meta = x.ToString() + number.ToString();
                x = int.Parse(meta);
                isXSet = true;
                skladiki.Text = "x = " + x.ToString() + "\ny = " + y.ToString();
            }
            else
            {
                string meta = y.ToString() + number.ToString();
                y = int.Parse(meta);
                isYSet = true;
                skladiki.Text = "x = " + x.ToString() + "\ny = " + y.ToString();
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            znak = '+';
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x + y;
                wyink.Text = ans.ToString();
                ResetVars();
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            znak = '-';
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x - y;
                wyink.Text = ans.ToString();
                ResetVars();
            }
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            znak = '*';
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x * y;
                wyink.Text = ans.ToString();
                ResetVars();
            }
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            znak = '/';
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                float ans = x / y;
                wyink.Text = ans.ToString();
                ResetVars();
            }
        }
        
        private void log_Click(object sender, RoutedEventArgs e)
        {
            znak = 'L';
            double logX = Math.Log(x);
            double logY = Math.Log(y);
            double logXY = Math.Log(x,y);
            double logYX = Math.Log(y,x);
            wyink.Text = $"{logX.ToString()} + 'log z: {x}' \n{logY.ToString()} + 'log z: {y}' \n{logXY.ToString()} + 'log z: {x} stopnia {y}' \n{logYX.ToString()} + 'log z: {y} stopnia {x}' \n";
            ResetVars();
        }

        private void change(object sender, RoutedEventArgs e)
        {
            setB = !setB;
            changebt.Content = !setB ? "A" : "B";
        }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            Delete();
        }
        
        private void Delete()
        {
            if (!setB)
            {
                if (x.ToString().Length > 1)
                {
                    string meta = x.ToString().Remove(x.ToString().Length - 1);
                    x = int.Parse(meta);
                    skladiki.Text = "x = " + x.ToString();
                }
                else
                {
                    x = 0;
                    isXSet = false;
                    skladiki.Text = "x = ";
                }
            }
            else
            {
                if (y.ToString().Length > 1)
                {
                    string meta = y.ToString().Remove(y.ToString().Length - 1);
                    y = int.Parse(meta);
                    skladiki.Text = "x = " + x.ToString() + "\ny = " + y.ToString();
                }
                else
                {
                    y = 0;
                    isYSet = false;
                    skladiki.Text = "x = " + x.ToString() + "\ny = ";
                }
            }
        }

        private void pot_Click(object sender, RoutedEventArgs e)
        {
            znak = '^';
            if (!isXSet || !isYSet)
            {
                wyink.Text = "nie ma jednej wartosci";
            }
            else
            {
                double ans = Math.Pow(x,y);
                wyink.Text = ans.ToString();
                ResetVars();
            }
        }

        private void ResetVars()
        {
            skladiki.Text = "";
            x = 0;
            y = 0;
            isXSet = false;
            isYSet = false;
        }
    }
}
