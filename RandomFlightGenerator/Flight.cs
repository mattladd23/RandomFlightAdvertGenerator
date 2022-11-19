using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFlightGenerator
{
    internal class Flight
    {
        // Generate random indicies in follow arrays
        public static Random Randomizer = new Random();

        // Array of departure airports 
        public string[] DepartureAirports = { "London Gatwick", "London Stansted", "London Luton", "London Heathrow", "London City" };

        // Array of destinations
        public string[] DestinationAirports = { "Paris", "Berlin", "Madrid", "New York", "Istanbul", "Nairobi", "Singapore" };

        // Array of seat classes
        public string[] Seats = { "First Class", "Business Class", "Economy Class" };

        // Empty string to populate using generate method
        public string Description = "";

        // Initialize arbitrary price
        public string Price;

        public void Generate()
        {
            // Variable to randomly select departure airport
            string randomDeparture = DepartureAirports[Randomizer.Next(DepartureAirports.Length)];

            // Variable to randomly select destination airport
            string randomDestination = DestinationAirports[Randomizer.Next(DestinationAirports.Length)];

            // Variable to randomly select seat class
            string randomSeat = Seats[Randomizer.Next(Seats.Length)];

            // Join random variables to produce random flight
            Description = randomDeparture + " to " + randomDestination + " in " + randomSeat;


            // Random price (pounds)
            decimal pounds = Randomizer.Next(1, 100);

            // Random price (pence)
            decimal pence = Randomizer.Next(1, 100);

            // Join pounds and pence to form final random price
            decimal price = pounds + (pence * .01M);

            // Convert price to string and format to local currency
            Price = "Now only " + price.ToString("c") + "!";
        }
    }
}
