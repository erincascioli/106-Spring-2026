using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{

    // Class wouldn't be named Singleton - it would be PlayerManager or whatever

    // Sealed to prevent inheritance, but not essential.
    // Sealed = communication to others that this can't (and shouldn't) be inherited from
    public sealed class Singleton
    {
        #region Singleton Stuff
        // The class has a member of itself as a STATIC private field.
        // Static --> Only one can exist. Because this is a static variable, it goes in the 
        //    special place in memory where static things go. (They're in a special section of the heap).
        //    Exists without any instantiation just by this class existing in my project.
        // Private --> no access outside of the property. We need this data protection.
        private static Singleton instance = null;

        // Private constructor so it can't be called outside of this class
        // The constructor is DEFAULT ONLY
        // It's called inside the property, and since it's instantiated inside the property
        //   no information can be passed to it from outside the class. 
        // Need to pass information into this class? Write an Initialize method.
        // Data can then be passed to this Singleton class after it's instantiated in Game1 (or wherever)
        private Singleton()
        {
            // The reason this is here is to show exactly when this class is initialized.
            this.creationTime = DateTime.Now.ToString();
        }

        // Although this is static (no reference to an object needed to use it) a regular
        //   object is returned.  The first time this property is invoked, the object is instantiated in
        //   the heap and a reference is returned.
        public static Singleton Instance
        {
            get
            {
                // Does it exist yet? No? Make it!
                if (instance == null)
                {
                    // Call the default constructor.
                    instance = new Singleton();
                    Console.WriteLine("New instance of this Singleton is created.");
                }
                else
                {
                    Console.WriteLine("Cannot initialize the Singleton! It already exists!");
                }

                // Return the (newly made or already made) instance
                return instance;
            }

            // NEVER include a set block!!
        }
        #endregion


        // The rest of the class is a NORMAL class.

        // Singleton classes can have any other fields needed.
        // Can contain fields, properties, etc that the class can use.
        private string word;
        private int number;

        // Fields can be initialized inside the constructor, if necessary.
        private string creationTime;

        // Initialize methods are usually written to give data to the class. 
        public void Initialize(string word, int number)
        {
            this.word = word;
            this.number = number;
        }

        // Normal method here
        public override string ToString()
        {
            return "PlayerManager singleton instance was created at " + creationTime;
        }

    }
}
