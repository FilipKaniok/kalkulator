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

namespace kalkulator
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double ResoultValue = 0;
        string OperationPerformed = "";
        bool isOperationPerformed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if ((display.Text == "0") || isOperationPerformed)
                display.Text = "";


            isOperationPerformed = false;
            display.Text = display.Text + button.Content;
        }

        private void operation_btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            OperationPerformed = button.Content.ToString();
            ResoultValue = Double.Parse(display.Text);

            isOperationPerformed = true;

            

        }

        private void Equals_btn_Click(object sender, RoutedEventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    display.Text = (ResoultValue + Double.Parse(display.Text)).ToString();
                    break;

                case "-":
                    display.Text = (ResoultValue - Double.Parse(display.Text)).ToString();
                    break;

                case "/":
                    if (ResoultValue.ToString() == "0")
                    {
                        display.Text = "Error";
                    }
                    display.Text = (ResoultValue / Double.Parse(display.Text)).ToString();
                    break;

                case "*":
                    display.Text = (ResoultValue * Double.Parse(display.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void reset_btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Content.ToString() == "C")
                display.Text = "0";
        }
    }
}
