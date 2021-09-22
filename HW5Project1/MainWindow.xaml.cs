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

namespace HW5Project1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight, height;

           if(double.TryParse(weightTextBox.Text, out weight) && double.TryParse(heightTextBox.Text, out height))
            {
                double bmi = (weight * 720) / (Math.Pow(height, 2));

                bmiTextBox.Text = Math.Round(bmi,1).ToString();

                if(bmi < 15)
                {
                    Console.WriteLine("You are under the healthy range.");
                    bmiTextBox.Background = Brushes.Blue;

                }
                else if (bmi > 26)
                {
                    Console.WriteLine("You are over the healthy range.");
                    bmiTextBox.Background = Brushes.Yellow;

                }
                else
                {
                    Console.WriteLine("You are in the healthy range.");
                    bmiTextBox.Background = Brushes.Green;

                }




            }
           else
            {
                MessageBox.Show("Error: Invalid Weight or Height.");
            }



        }

  
    }
}
