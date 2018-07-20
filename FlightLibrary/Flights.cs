using System.Collections;

namespace FlightLibrary
{
    // Done: Task2 - Design a Flight Collection Class.

    /// <summary>
    /// Represents a collection of Flight instances.
    /// </summary>
    public class Flights : CollectionBase, IEnumerable
    {

        #region Properties
        /// <summary>
        /// Gets/Sets value for the item by that index
        /// </summary>
        public Flight this[int index]
        {
            get
            {
                return (Flight)List[index];
            }
            set
            {
                List[index] = value;
            }
        }

        #endregion

        #region Public Methods

        public int IndexOf(Flight FlightItem)
        {
            if (FlightItem != null)
            {
                return List.IndexOf(FlightItem);
            }
            return -1;
        }

        public int Add(Flight FlightItem)
        {
            if (FlightItem != null)
            {
                return List.Add(FlightItem);
            }
            return -1;
        }

        public void Remove(Flight FlightItem)
        {
            InnerList.Remove(FlightItem);
        }

        public void AddRange(Flights collection)
        {
            if (collection != null)
            {
                InnerList.AddRange(collection);
            }
        }

        public void Insert(int index, Flight FlightItem)
        {
            if (index <= List.Count && FlightItem != null)
            {
                List.Insert(index, FlightItem);
            }
        }

        public bool Contains(Flight FlightItem)
        {
            return List.Contains(FlightItem);
        }

        #endregion

    }
}
