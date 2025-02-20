namespace COMP003A.ZooManagementSystem
{
    class Parrot : Animal
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public Parrot(string parrotName, string parrotSpecies)
        {
            Name = parrotName;
            Species = parrotSpecies;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The parrot squawks! ({Name}, {Species})");
        }
    }
}
