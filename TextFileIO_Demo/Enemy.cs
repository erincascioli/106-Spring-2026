using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileIO_Demo
{
    internal class Enemy
    {
        // --------------------------------------------------------------------
        // Data (fields)
        // --------------------------------------------------------------------
        private string name;
        private int attack;
        private int health;

        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

        // None!  No access needed to any of this Enemy's data from outside of 
        //   this containing class.


        // --------------------------------------------------------------------
        // Parameterized constructor
        // --------------------------------------------------------------------

        /// <summary>
        /// Constructs and Enemy object
        /// </summary>
        /// <param name="name">Name of the enemy</param>
        /// <param name="attack">Attack value</param>
        /// <param name="health">Health value</param>
        public Enemy(string name, int attack, int health)
        {
            this.name = name;
            this.attack = attack;
            this.health = health;
        }


        // --------------------------------------------------------------------
        //  Methods (behaviors)
        // --------------------------------------------------------------------

        /// <summary>
        /// Formats Enemy data in a readable string
        /// </summary>
        /// <returns>String representation of an Enemy object</returns>
        public override string ToString()
        {
            string formattedInfo = 
                String.Format(name + ": " + "Health of " + health + " and attacks for " + attack);
            return formattedInfo;

            // Or you could use string interpolation like this:
            //return $"name: Health of {health} and attacks for {attack}";
        }
    }
}
