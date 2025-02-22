using System.Xml.Linq;

namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Species"></param>
        public Lion(string lionName, string lionSpecies) 
        {
            Name = lionName;
            Species = lionSpecies;
        }

        /// <summary>
        /// will override to make sound displaying name and species
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"The lion roars! ({Name}, {Species})");
        }
    }
}
