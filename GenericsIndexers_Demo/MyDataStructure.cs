using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsIndexers_Demo
{
    /// <summary>
    /// My own custom data structure, built to demonstrate generics and indexers.
    /// </summary>
    internal class MyDataStructure<T>
    {
        // Using the built-in List class to hold this class's data
        private List<T> myData;
        private T someValue;

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= Size)
                {
                    throw new Exception("Out of range");
                }

                return myData[index];
            }
            set
            {
                // Verify in range index
                myData[index] = value;
            }
        }


        // NOOOOOOOOOOOOOOOOOOOOOOO
        /*
        public List<T> ClassData
        {
           get { return myData; }
        }
        */

        /// <summary>
        /// Allows external classes access to how much data is in the data structure
        /// </summary>
        public int Size
        {
            get { return myData.Count; }
        }

        /// <summary>
        /// Constructs a new data structure
        /// </summary>
        public MyDataStructure()
        {
            myData = new List<T>();
            someValue = default(T);
        }

        /// <summary>
        /// Adds any string to this data structure's list
        /// </summary>
        /// <param name="newData"></param>
        public void Add(T newData)
        {
            myData.Add(newData);
        }

        /// <summary>
        /// Returns data at a specified index
        /// </summary>
        /// <param name="specifiedIndex">Index to retrieve data</param>
        /// <returns>Data at the specified index, when the index is valid.</returns>
        /// <exception cref="Exception">Invalid indices (too small or large) do not return data.</exception>
        public T GetData(int specifiedIndex)
        {
            // Out of range? Throw an exception to represent that the requested operation
            //   CANNOT be done.
            // Code that CALLS this GetData method should use a try/catch block to prevent
            //   crashing. 

            // Invalid index:
            if(specifiedIndex >= myData.Count ||
                specifiedIndex < 0)
            {
                // Throws a new exception with Message property below
                throw new Exception("Index is out of range.");
            }

            // Valid index:
            return myData[specifiedIndex];
        }
    }
}
