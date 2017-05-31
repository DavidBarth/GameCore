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
        /// decrements health by the amount of damage
        /// </summary>
        /// <param name="damage"></param>
        public void Hit(int damage)
        {
            Health -= damage;

            if (Health <= 0)
                IsDead = true;
        }

        

        
    }
}
