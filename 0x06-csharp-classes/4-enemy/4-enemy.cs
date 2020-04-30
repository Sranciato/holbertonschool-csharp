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
        string name = "(No Name)";
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
        /// <summary>
        /// public property: get and set name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// public constructor: returns value of health
        /// </summary>
        public int GetHealth()
        {
            return health;
        }
    }
}