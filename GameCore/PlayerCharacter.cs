
using System;
using System.Collections.Generic;
using System.Linq;

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
        /// collection of magical items
        /// </summary>
        public List<MagicalItem> MagicalItems { get; set; } = new List<MagicalItem>();

        /// <summary>
        /// returns sum of magical items power
        /// </summary>
        public int MagicalPower
        {
            get { return MagicalItems.Sum(i => i.Power); }
        }

        /// <summary>
        /// collection of weapons
        /// </summary>
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();

        /// <summary>
        /// returns sum of weapons value
        /// </summary>
        public int WeaponsValue
        {
            get { return Weapons.Sum(v => v.Value); }
        }

        /// <summary>
        /// type of playercharacter
        /// </summary>
        public CharacterClass CharacterClass { get; set; }



        public DateTime LastSleepTime { get; set; }



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

        /// <summary>
        /// restores Health if we are healers otherwise adds 10
        /// </summary>
        public void CastHealingSpell()
        {
            if(CharacterClass==CharacterClass.Healer)
            {
                Health = 100;
            }
            else
            {
                Health += 10;
            }
        }

        /// <summary>
        /// restores health if we slept lest than 3 days ago
        /// </summary>
        public void ReadHealthScroll()
        {
            var daysSinceLastSleep = DateTime.Now.Subtract(LastSleepTime).Days;

            if(daysSinceLastSleep <= 2)
            {
                Health = 100;
            }
        }

        /// <summary>
        /// reduce itempower
        /// </summary>
        /// <param name="itemName"></param>
        public void UseMagicalItem(string itemName)
        {
            int powerReduction = 10;

            if (Race == "Elf")
            {
                powerReduction = 0;
            }
            var itemToReduce = MagicalItems.First(item => item.Name == itemName);

            itemToReduce.Power -= powerReduction;

        }
    }
}
