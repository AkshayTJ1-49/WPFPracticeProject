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

namespace WpfCoreCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        selectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();        
            acButton.Click += AcButton_Click;
            negetiveButton.Click += NegetiveButton_Click;
            percetageButton.Click += PercetageButton_Click;
            equalButton.Click += EqualButton_Click;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case selectedOperator.Addtion:
                        result = SimpleMath.Addition(lastNumber, newNumber);
                        break;
                    case selectedOperator.Subtraction:
                        result = SimpleMath.Subtraction(lastNumber, newNumber);
                        break;
                    case selectedOperator.Multiplication:
                        result = SimpleMath.Multiplication(lastNumber, newNumber);
                        break;
                    case selectedOperator.Division:
                        result = SimpleMath.Division(lastNumber, newNumber);
                        break;
                }

                resultLabel.Content = result.ToString();
            }
        }
        private void OprationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }

            if (sender == multiplyButton)
                selectedOperator = selectedOperator.Multiplication;
            if (sender == divsionButton)
                selectedOperator = selectedOperator.Division;
            if (sender == additionButton)
                selectedOperator = selectedOperator.Addtion;
            if (sender == subtractionButton)
                selectedOperator = selectedOperator.Subtraction;
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedNumber = int.Parse((sender as Button).Content.ToString());

            if (resultLabel.Content.ToString()=="0")
            {
                resultLabel.Content = selectedNumber.ToString();
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedNumber}";
            }


        }

        private void PercetageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegetiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == ".")
            {
                //Do nothing
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }


        //private void sevenButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (resultLabel.Content.ToString() == "0")
        //    {
        //        resultLabel.Content = "7";
        //    }
        //    else
        //        resultLabel.Content = $"{resultLabel.Content}7";
        //}

    }
    public enum selectedOperator
    {
        Addtion,
        Subtraction,
        Multiplication,
        Division
    }
    public class SimpleMath
    {
        public static double Addition(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtraction(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplication(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Division(double n1, double n2)
        {
            if (n2==0)
            {
                MessageBox.Show("Division by 0 not supported","Wrong Opration",MessageBoxButton.OK,MessageBoxImage.Error);
                return 0;
            }
            return n1/n2;
        }
    }
}
