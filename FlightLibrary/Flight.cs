using System;
using System.Collections.Generic;

namespace FlightLibrary
{
    // Done: Task1 - Design a Flight Class.

    /// <summary>
    /// Represents an instant of flight..
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Specifies the name of the flight.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specifies the Company flight belongs to.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Specifies the boarding time of the flight.
        /// </summary>
        public DateTime BoardingTime { get; set; }

        /// <summary>
        /// Specifies the departing time of the flight.
        /// </summary>
        public DateTime DepartingTime { get; set; }

        /// <summary>
        /// Specifies the name of the flight.
        /// </summary>
        public Location DepartingPlace { get; set; }

        /// <summary>
        /// Specifies the destination(Final Stop) of the flight.
        /// </summary>
        public Location DestinationPlace { get; set; }

        /// <summary>
        /// Specifies the pilot id for the flight. (We can also have a seperate class for this)
        /// </summary>
        public int PilotId { get; set; }

        /// <summary>
        /// Specifies the list of stops between start and last location.
        /// </summary>
        public List<String> Stops { get; set; }

        /// <summary>
        /// Specifies the number of seats in the flight.
        /// </summary>
        public int SeatCount { get; set; }

        /// <summary>
        /// Specifies the country the flight belongs to.
        /// </summary>
        public string AirlineCountry { get; set; }
    }





}
