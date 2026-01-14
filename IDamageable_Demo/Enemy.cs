using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    /// <summary>
    /// Enemy that will auto-attack a player
    /// </summary>
	class Enemy
	{
        private int health;
        private Weapon weapon;

        /// <summary>
        /// Creates an enemy with a health and chosen weapon
        /// </summary>
        /// <param name="health">Starting health value</param>
        /// <param name="weapon">Choice of weapon</param>
        public Enemy(int health, Weapon weapon)
        {
            this.health = health;
            this.weapon = weapon;
        }

       
		// *******************************************************
        // Because Player and Door implement the same interface, 
        //   these separate methods for attacking Player objects 
        //   and Door objects aren't really needed!
        // *******************************************************

        /// <summary>
        /// Attack any Player object
        /// </summary>
        /// <param name="player">Reference to the player/param>
        public void Attack(Player player)
        {
			switch (weapon)
			{
				case Weapon.Crossbow:
					player.TakeDamage(10);
					break;
				case Weapon.ScorpionOnAStick:
					player.TakeDamage(1);
					break;
			}
		}


		/// <summary>
		/// Attack any Door object
		/// </summary>
		/// <param name="door">Reference to a door</param>
		public void Attack(Door door)
		{
			switch (weapon)
			{
				case Weapon.Crossbow:
					door.TakeDamage(10);
					break;
				case Weapon.ScorpionOnAStick:
					door.TakeDamage(1);
					break;
			}
		}
		

		/// <summary>
		/// Causes harm to any object implementing the IDamageable interface
		/// </summary>
		/// <param name="obj">Object to damage</param>
		public void Attack(IDamageable obj)
		{
			switch (weapon)
			{
				case Weapon.Crossbow:
					obj.TakeDamage(10);
					break;
				case Weapon.ScorpionOnAStick:
					obj.TakeDamage(1);
					break;
			}
		}

	}
}
