using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    /// <summary>
    /// Describes the type of weapon that a Player holds
    /// </summary>
    public enum Weapon
    {
        Longsword,
        Shortsword,
        Axe,
        Dagger,
        Crossbow,
        Stick,
        Fist,
        ScorpionOnAStick
    }

    /// <summary>
    /// User-driven character
    /// </summary>
    class Player : IDamageable
	{
        private const int MaxHealth = 100;
        private int health;
        private string name;
        private Weapon weapon;
        private int number;

        public int Number
        {
            get { return 5; }
            set { number = value; }
        }
               

        // Required by the interface
        public int CurrentDamage
        {
            get
            {
                // You're not required to make a matching backing field
                //   and return it - sometimes it makes more sense
                //   to use the fields you already have.
                return MaxHealth - health;
            }
        }


        /// <summary>
        /// Creates a player with the specified name and no damage
        /// </summary>
        /// <param name="name">The name of the player</param>
        /// <param name="weapon">Type of weapon player utilizes</param>
        public Player(string name, Weapon weapon)
        {
            this.name = name;
            this.weapon = weapon;
            this.health = MaxHealth;
        }


        /// <summary>
        /// Determines if player has succumbed yet
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            if(health <= 0)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Summary of this player's stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Player {name} is using the {weapon} and has {health} hit points left.";
        }


        /// <summary>
        /// Reduces a player's health when hit
        /// </summary>
        /// <param name="amountOfDamage">Number of hit points</param>
        public void TakeDamage(int amountOfDamage)
        {
            // Negative damage should not heal the player
            // Only receive positive damage instead
            if (amountOfDamage > 0)
            {
                health -= amountOfDamage;
            }
        }
    }
}
