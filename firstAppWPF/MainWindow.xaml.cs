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

namespace firstAppWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void MyFirstDelegate(string str);
        event MyFirstDelegate MyFirstEvent;

        Button SecondButton;
        public MainWindow()
        {
            InitializeComponent();
            SecondButton = new Button();
            SecondButton.Content = "It's my second button";
            SecondButton.Click += SecondButton_click;
            FirstStackPanel.Children.Add(SecondButton);

            // equal if i call methode ItsOneMethodeItsMethode it's a lambda methode
            MyFirstEvent += (str) =>
            {
                FirstLabel.Content = str;
            };


        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            MyFirstEvent("first button");
        }


        private void SecondButton_click(object sender, RoutedEventArgs e)
        {
            MyFirstEvent("seconde button");
        }

        private void ItsOneMethodeItsMethode(string str)
        {
            FirstLabel.Content = str;
        }

    }
}
