using System;

namespace GameCore
{
    /// <summary>
    /// Player character class
    /// </summary>
    public class PlayerCharacter
    {
        public int Health { get; private set; } = 100;

        public bool  IsDead { get;private set; }

        /// <summary>
        /// example if the damage resistance is 10 
        /// and player gets hit with 10
        /// no damage will occur
        /// </summary>
        public int DamageResistance { get; set; }

        public string Race { get; set; }
        /// <summary>
        /// decrements health by the amount of damage
        /// </summary>
        /// <param name="damage"></param>
        public void Hit(int damage)
        {
            var raceSpecificDamageResistance = 0;

            //additional damage resistance
            if (Race == "Elf")
            {
                raceSpecificDamageResistance = 20;
            }

            var totalDamageTaken =
                Math.Max(damage - raceSpecificDamageResistance - DamageResistance, 0);

            Health -= totalDamageTaken;

            if (Health <= 0)
                IsDead = true;
        }

        

        
    }
}
