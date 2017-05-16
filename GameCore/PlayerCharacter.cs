namespace GameCore
{
    /// <summary>
    /// Player character class
    /// </summary>
    class PlayerCharacter
    {
        public int Health { get; private set; } = 100;

        public bool  IsDead { get;private set; }

        /// <summary>
        /// decrements health by the amount of damage
        /// </summary>
        /// <param name="damage"></param>
        public void HitOnHead(int damage)
        {
            Health -= damage;

            if (Health <= 0)
                IsDead = true;
        }

        /// <summary>
        /// decrements health by the amount of damage
        /// </summary>
        /// <param name="damage"></param>
        public void HitOnBody(int damage)
        {
            Health -= damage;

            if (Health <= 0)
                IsDead = true;

        }

        /// <summary>
        /// decrements health by the amount of damage
        /// </summary>
        /// <param name="damage"></param>
        public void HitOnArm(int damage)
        {
            Health -= damage;

            if (Health <= 0)
                IsDead = true;

        }

        /// <summary>
        /// decrements health by the amount of damage
        /// </summary>
        /// <param name="damage"></param>
        public void HitOnLeg(int damage)
        {
            Health -= damage;

            if (Health <= 0)
                IsDead = true;

        }

        
    }
}
