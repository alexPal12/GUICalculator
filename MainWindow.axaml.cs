using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis;
using System;


namespace InClassCalculator
{
    public partial class MainWindow : Window
    {
        Solver Calsolver;
        public MainWindow()
        {
            InitializeComponent();
            TextBox1.Text = "";
            Calsolver = new Solver();
        }
        // Numbers 0-9
        public void Button1ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "1";
            Calsolver.Accumulate("1");
        }
        public void Button2ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "2";
            Calsolver.Accumulate("2");
        }
        public void Button3ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "3";
            Calsolver.Accumulate("3");
        }
        public void Button4ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "4";
            Calsolver.Accumulate("4");
        }
        public void Button5ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "5";
            Calsolver.Accumulate("5");
        }
        public void Button6ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "6";
            Calsolver.Accumulate("6");
        }
        public void Button7ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "7";
            Calsolver.Accumulate("7");
        }
        public void Button8ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "8";
            Calsolver.Accumulate("8");
        }
        public void Button9ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "9";
            Calsolver.Accumulate("9");
        }
        public void Button0ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "0";
            Calsolver.Accumulate("0");
        }
        // Operations
        public void ACClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "";
            //Calsolver.Clear();
        }
        public void PlusClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "+";
            Calsolver.Accumulate("+");
        }
        public void MinusClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "-";
            Calsolver.Accumulate("-");
        }
        public void MultiClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "*";
            Calsolver.Accumulate("*");
        }
        public void DivClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "/";
            Calsolver.Accumulate("/");
        }
        public void ModClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += "%";
            Calsolver.Accumulate("%");
        }
        public void DecimalClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text += ".";
            Calsolver.Accumulate(".");
        }
        public void PLMClickHandler(object sender, RoutedEventArgs args)
        {
            if (TextBox1.Text.Length > 0 && TextBox1.Text[0] == '-')
            {
                TextBox1.Text = TextBox1.Text.Substring(1);
            }
            else
            {
                TextBox1.Text = TextBox1.Text.Insert(Solver.count-1, "-");
            }


            Calsolver.Accumulate("-");
        }
        public void EqualsClickHandler(object sender, RoutedEventArgs args)
        {
            try
            {
                string job = TextBox1.Text;

                Calsolver.Clear();
                Calsolver.Accumulate(job);

                double equals = Calsolver.solve();
                string combinedString = job + Environment.NewLine +
                        "----------------" + Environment.NewLine +
                        equals.ToString();

                TextBox1.Text = combinedString;

            }
            catch (Exception ex)
            {
                TextBox1.Text = "Mistake: " + ex.Message;
            }
        }
    }
}