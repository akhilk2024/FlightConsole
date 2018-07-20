using System;
using System.Collections.Generic;

namespace FlightLibrary
{
    // Done: Task3 - Extension Method on Flight Collection Class.

    /// <summary>
    /// Represent an extension method for Flight Collection.
    /// </summary>
    public static class FlightExtension
    {

        /// <summary>
        /// Filters a flight based on the given condition (predicate).
        /// </summary>
        /// <param name="flights">source flight collection.</param>
        /// <param name="filterCondition">filter condition to filter the flights.</param>
        /// <returns>Returns the flight collection.</returns>
        public static IEnumerable<Flight> Filter(this IEnumerable<Flight> flights, Func<Flight, bool> filterCondition)
        {
            if (flights == null) throw new ArgumentNullException("flights");
            if (filterCondition == null) throw new ArgumentNullException("filterCondition");

            foreach (var flight in flights)
            {
                if (filterCondition(flight))
                    yield return flight;

            }
        }

    }
}
