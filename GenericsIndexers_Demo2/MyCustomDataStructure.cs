using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIndexers_Demo2
{
    /// <summary>
    /// My own custom data structure, built to demonstrate generics and indexers.
    /// </summary>
    internal class MyCustomDataStructure<T>
    {
        // Using the built-in List class to hold this class's data
        private List<T> myData;
        private T myField; 

        // WHAT IS THE INHERENT 'DANGER' IN THIS PROPERTY?
        // NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!
        /*
        public List<string> MyData
        {
            get { return myData; }
        }
        */

        /// <summary>
        /// Returns amount of data within this class's list
        /// </summary>
        public int Size
        {
            get { return myData.Count; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= myData.Count)
                {
                    throw new Exception("Index out of range");
                }

                return myData[index];
            }
        }


        /// <summary>
        /// Instantiates an objct of this class.
        /// </summary>
        public MyCustomDataStructure()
        {
            myData = new List<T>();
            myField = default(T);
        }

        /// <summary>
        /// Adds any string to this data structure's list
        /// </summary>
        /// <param name="newData">String of data to enter into the list</param>
        public void Add(T newData)
        {
            myData.Add(newData);
        }

        /// <summary>
        /// Returns data at a specified index
        /// </summary>
        /// <param name="index">Specified index</param>
        /// <returns>Data in the list at specified index</returns>
        /// <exception cref="Exception">Invalid indices throw an exception</exception>
        public T GetData(int index)
        {
            if(index < 0 || index >= myData.Count)
            {
                throw new Exception("Index out of range");
            }

            return myData[index];
        }
    }
}
