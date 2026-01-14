using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    /// <summary>
    /// Type of material a door is comprised of
    /// </summary>
    public enum DoorMaterial
    {
        Wood,
        Iron,
        Stone
    }

    /// <summary>
    /// Represents a barrier to a room or area in a game
    /// </summary>
    class Door : IDamageable
    {
        private DoorMaterial doorMaterial;
        private int damageThreshold;
        private int maxHitPoints;

        // Added after implementing the interface
        private int currentDamage;

        // Required by the interface
        public int CurrentDamage
        {
            get
            {
                return currentDamage;
            }
        }

        // Not required by the interface
        public int MaxHitPoints
        {
            get { return maxHitPoints; }
        }

        /// <summary>
        /// Barrier to a locked place 
        /// </summary>
        /// <param name="material">Type of building material door is made of</param>
        public Door(DoorMaterial material)
        {
            this.doorMaterial = material;

            switch (this.doorMaterial)
            {
                case DoorMaterial.Wood:
                    damageThreshold = 10;
                    maxHitPoints = 50;
                    break;
                case DoorMaterial.Iron:
                    damageThreshold = 25;
                    maxHitPoints = 150;
                    break;
                case DoorMaterial.Stone:
                    damageThreshold = 40;
                    maxHitPoints = 200;
                    break;
            }
        }

        /// <summary>
        /// Increases the amount of damage this Door has taken
        /// if it surpasses this door's damage threshold
        /// </summary>
        /// <param name="amountOfDamage"></param>
        public void TakeDamage(int amountOfDamage)
        {
            if (amountOfDamage >= damageThreshold)
            {
                currentDamage += amountOfDamage;
            }
        }

        /// <summary>
        /// Has the door been destroyed?
        /// </summary>
        /// <returns></returns>
        public bool IsBroken()
        {
            if (currentDamage >= maxHitPoints)
            {
                return true;
            }

            return false;
        }
    }
}
