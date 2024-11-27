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

namespace temperature_calculator
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
            float piniomzki;
            if (float.TryParse(pieniomzki.Text, out piniomzki))
            {
                if (euro.IsChecked == true)
                {
                    piniomzki = piniomzki* 0.23f;
                    MessageBox.Show(piniomzki + "Euro", "Przeliczone", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (frank.IsChecked == true)
                {
                    piniomzki = piniomzki * 0.22f;
                    MessageBox.Show(piniomzki + "Franki", "Przeliczone", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (dolar.IsChecked == true)
                {
                    piniomzki = piniomzki * 0.24f;
                    MessageBox.Show(piniomzki + "Dolary", "Przeliczone", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
            }
            else
            {
                MessageBox.Show(piniomzki + "Jesteś trochę niedorozwinięty", "Ważna infora", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void temp(object sender, RoutedEventArgs e)
        {
            float temperatura;
            if (float.TryParse(tempWej.Text, out temperatura))
            {
                if (cwej.IsChecked == true)
                {
                    if (fwyj.IsChecked == true)
                    {
                        temperatura = (temperatura*2)-30;
                    }
                    else if (kwyj.IsChecked == true)
                    {
                        temperatura = temperatura - 273.15f;
                    }
                }
                else if (fwej.IsChecked == true)
                {
                    if (cwyj.IsChecked == true)
                    {
                        temperatura = (temperatura + 30)/2 ;
                    }
                    else if (kwyj.IsChecked == true)
                    {
                        temperatura = temperatura * 0.24f;
                    }
                }
                else if (kwej.IsChecked == true)
                {
                    if (cwyj.IsChecked == true)
                    {
                        temperatura = temperatura * 0.22f;
                    }
                    else if (fwyj.IsChecked == true)
                    {
                        temperatura = temperatura * 0.24f;
                    }
                }
                tempWyj.Text = Convert.ToString(temperatura);
            }
            else
            {
                MessageBox.Show(temperatura + "Jesteś trochę niedorozwinięty", "Ważna infora", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }
    }
}
