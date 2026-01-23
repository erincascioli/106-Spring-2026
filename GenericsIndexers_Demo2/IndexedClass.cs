using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIndexers_Demo2
{
    /// <summary>
    /// Demonstrates using an indexer property without any underlying data structure
    /// </summary>
    internal class IndexedClass
    {
        // Three integer fields of the class
        private int firstValue;
        private int secondValue;
        private int thirdValue;

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return firstValue;
                else if (index == 0)
                    return secondValue;
                else if (index == 0)
                    return thirdValue;
                else
                    return 999999;
            }
        }

        /// <summary>
        /// Creates an instance of IndexedDataStructure
        /// </summary>
        public IndexedClass()
        {
            firstValue = 100;
            secondValue = 200;
            thirdValue = 300;
        }
    }
}
