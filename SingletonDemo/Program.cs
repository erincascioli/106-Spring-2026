using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cannot use the constructor because it's private!  
            //Singleton mySingleton = new Singleton();
           
            // Instantiates the single instance of this class
            // AND fills it with data needed for the class.

            // Uses the get Instance property of the Singleton class
            // If the Singleton instance doesn't yet exist, it makes one
            // If it does exist, it returns a reference to that object
            Singleton.Instance.Initialize("hi", 10);
            
            // Can we overwrite the instance? Let's try.
            for(int i=0; i < 5; i++)
            {
                // Print the time that the Singleton instance was created
                Console.WriteLine(DateTime.Now + ": " + Singleton.Instance);
                Thread.Sleep(2000);
            }
        }
    }
}
