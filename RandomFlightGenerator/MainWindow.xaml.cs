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

namespace RandomFlightGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeFlight();
        }

        private void MakeFlight()
        {
            // Declare new array for flights
            Flight[] flights = new Flight[6];         

            for (int i = 0; i < flights.Length; i++)
            {
                // Instantiate flight for each indicies
                flights[i] = new Flight();

                // Include condition to have lower flights as domestic flights
                if (i >= 3)
                {
                    flights[i].DestinationAirports = new string[]
                    {
                        "Manchester", "Newcastle", "Bristol", "Glasgow", "Belfast"
                    };
                }

                // Invoke generate method from flight class
                flights[i].Generate();
            }

            // Allocate flight descriptions and prices
            flight1.Text = flights[0].Description;
            price1.Text = flights[0].Price;

            flight2.Text = flights[1].Description;
            price2.Text = flights[1].Price;

            flight3.Text = flights[2].Description;
            price3.Text = flights[2].Price;

            flight4.Text = flights[3].Description;
            price4.Text = flights[3].Price;

            flight5.Text = flights[4].Description;
            price5.Text = flights[4].Price;

            
            // Create special flight for bottom flight
            Flight specialFlight = new Flight()
            {
                DepartureAirports = new string[] { "London Southend", "Norwich" },
                DestinationAirports = new string[]
                {
                    "Malaga", "Amsterdam", "Exeter"
                }
            };
            specialFlight.Generate();

            // Allocate final flight instance to special flight fields
            flight6.Text = specialFlight.Description;
            price6.Text = specialFlight.Price;
        }
    }    
}
