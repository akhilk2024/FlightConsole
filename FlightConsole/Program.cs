using FlightLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a flight collection.
            Flights flights = new Flights();
            flights.Add(new Flight() { Name = "Flight-1", Company = "Company-1", AirlineCountry = "USA" });
            flights.Add(new Flight() { Name = "Flight-2", Company = "Company-1", AirlineCountry = "GERMANY" });
            flights.Add(new Flight() { Name = "Flight-3", Company = "Company-2", AirlineCountry = "INDIA" });
            flights.Add(new Flight() { Name = "Flight-4", Company = "Company-3", AirlineCountry = "FRANCE" });

            // Testing Code
            var inputData = new StringBuilder();

            // Printing Sample Data
            Console.WriteLine($"Name    Company     AirlineCountry");
            flights.Cast<Flight>().ToList().ForEach(f =>
            {
                Console.WriteLine($"{f.Name}    {f.Company}     {f.AirlineCountry}");
            });


            Test(flights, "Name");
            Test(flights, "Company");
            Test(flights, "AirlineCountry");

            Console.WriteLine("Test Completed!");
            Console.WriteLine("press any key to exit.");
            Console.ReadKey();

        }

        private static void Test(Flights inputFlights, string testColumnName)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Provide flight {testColumnName} to search");

            var inputText = Console.ReadLine();

            var searchResult = new List<Flight>();

            switch (testColumnName.ToLower())
            {
                case "name":
                    searchResult = inputFlights.Cast<Flight>().Filter(f => f.Name.ToLower() == inputText.ToLower()).ToList();
                    break;
                case "company":
                    searchResult = inputFlights.Cast<Flight>().Filter(f => f.Company.ToLower() == inputText.ToLower()).ToList();
                    break;
                case "airlinecountry":
                    searchResult = inputFlights.Cast<Flight>().Filter(f => f.AirlineCountry.ToLower() == inputText.ToLower()).ToList();
                    break;

            }


            var result = searchResult.Cast<Flight>().ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No Record Found");
            }
            else
            {
                searchResult.Cast<Flight>().ToList().ForEach(f =>
                {
                    Console.WriteLine($"{f.Name}    {f.Company}     {f.AirlineCountry}");
                });
            }

        }
    }
}
