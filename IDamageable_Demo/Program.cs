using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Erin Cascioli
// Demo: Interfaces

namespace InterfaceDemo
{
	class Program
	{
		static void Main(string[] args)
		{
            // ----------------------------------------------------------------
            // Set up game
            // ----------------------------------------------------------------
            // Instantiate a few players
            Player player1 = new Player("Anna", Weapon.Dagger);
			Player player2 = new Player("Dash", Weapon.Longsword);

            // Wooden door to a safe place
            Door lockedDoor = new Door(DoorMaterial.Wood);

            // Instantiate some enemies
            Enemy badGuy1 = new Enemy(50, Weapon.Crossbow);
            Enemy badGuy2 = new Enemy(50, Weapon.ScorpionOnAStick);
            Enemy badGuy3 = new Enemy(50, Weapon.Fist);


            // List of all things in the environment close to badGuy1
            List<IDamageable> badGuy1Area = new List<IDamageable>();
            badGuy1Area.Add(player1);
            badGuy1Area.Add(player2);
            badGuy1Area.Add(lockedDoor);
            // ----------------------------------------------------------------


            // ----------------------------------------------------------------
            // Print player data
            // ----------------------------------------------------------------
            Console.WriteLine(player1);
            Console.WriteLine("Anna has taken {0} damage", player1.CurrentDamage);
            Console.WriteLine(player2);
            Console.WriteLine("Dash has taken {0} damage", player2.CurrentDamage);
            Console.WriteLine("Door: {0} damage/{1} HP", 
                lockedDoor.CurrentDamage, 
                lockedDoor.MaxHitPoints);
            // ----------------------------------------------------------------


            // ----------------------------------------------------------------
            // Attacks!
            // ----------------------------------------------------------------
            // Guy #1 attacks the door befpre anything else
            badGuy1.Attack(lockedDoor);     // Successful attack

			// Guy #2 attacks Dash and then the door
            badGuy2.Attack(player2);
			badGuy2.Attack(lockedDoor);		// Unsuccessful attack	

			// Guy #1 whirlwind attacks, hitting everything in the current area.
			foreach (IDamageable obj in badGuy1Area)
			{
				badGuy1.Attack(obj);
			}

            // Guy #3 isn't close enough to attack anyone/anything
            // ----------------------------------------------------------------


            // ----------------------------------------------------------------
            // Check the damage that all have taken so far
            // ----------------------------------------------------------------
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(player1);
            Console.WriteLine("Anna has taken {0} damage", player1.CurrentDamage);
            Console.WriteLine(player2);
            Console.WriteLine("Dash has taken {0} damage", player2.CurrentDamage);
            Console.WriteLine("Door: {0} damage/{1} HP", 
                lockedDoor.CurrentDamage, 
                lockedDoor.MaxHitPoints);
            // ----------------------------------------------------------------
        }
    }
}
