namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public Lion(string lionName, string lionSpecies) 
        {
            Name = lionName;
            Species = lionSpecies;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The lion roars! ({Name}, {Species})");
        }
    }
}
