﻿namespace COMP003A.ZooManagementSystem
{
    class Parrot : Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Species"></param>
        public Parrot(string parrotName, string parrotSpecies)
        {
            Name = parrotName;
            Species = parrotSpecies;
        }

        /// <summary>
        /// will override make sound and dispay name and species
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"The parrot squawks!");
        }
    }
}
