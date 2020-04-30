using System;

namespace Enemies
{
    /// <summary>
    /// Zombie class that defines Enemies
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// public field health
        /// </summary>
        public int health;
        /// <summary>
        /// public constructor
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// public constructor: checks if value is positive
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}