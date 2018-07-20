namespace FlightLibrary
{
    public class Location
    {
        /// <summary>
        /// Specifies the city of the location
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Specifies the State of the location
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Specifies the State of the location
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Specifies the terminal of the flight  where it will start  or landing.
        /// </summary>
        public string DepartingTerminal { get; set; }

        /// <summary>
        /// Specifies the gate of the flight where it will start  or landing.
        /// </summary>
        public string Gate { get; set; }


    }
}
