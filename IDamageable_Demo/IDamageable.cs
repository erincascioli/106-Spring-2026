using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
	interface IDamageable
	{
		// COMMENT your interfaces!!!!

		// Return the total amount of damage an object has taken so far
		int CurrentDamage { get; }

		// Reduce an object's health and/or increase the damage that an 
		//   object has taken
		// Harm the object by a set amount
		void TakeDamage(int amount);
	}
}
