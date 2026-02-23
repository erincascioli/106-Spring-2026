using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIndexers_Demo
{
    /// <summary>
    /// Demonstrates using an indexer property without any underlying data structure
    /// </summary>
    internal class IndexedDataStructure
    {
        // Three integer fields of the class
        private int valueOne;
        private int valueTwo;
        private int valueThree;

        /// <summary>
        /// Indexer property allows the class to be indexed as if it were an array
        /// </summary>
        /// <param name="index">Number of index to retrieve</param>
        /// <returns>Values one, two, or three</returns>
        /// <exception cref="Exception">Invalid indices throw an exception</exception>
        public int this[int index]
        {
            get 
            {
                if (index == 0)
                    return valueOne;
                else if (index == 1)
                    return valueTwo;
                else if (index == 2)
                    return valueThree;
                else
                    throw new Exception("Index is out of range");
            }
            set { }
        }

        /// <summary>
        /// Creates an instance of IndexedDataStructure
        /// </summary>
        public IndexedDataStructure()
        {
            valueOne = 19;
            valueTwo = int.MaxValue;
            valueThree = 3;
        }
    }
}
