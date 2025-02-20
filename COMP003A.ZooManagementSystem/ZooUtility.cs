using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    public class ZooUtility
    {
        /// <summary>
        /// display animal name 
        /// </summary>
        /// <param name="name"></param>
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Animal Name: {name}");
        }

        /// <summary>
        /// display animal name and species
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public static void DescribeAnimal(string name, string species)
        {
            DescribeAnimal(name);
            Console.WriteLine($"Animal Species: {species}");
        }

        /// <summary>
        /// display name, species, and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        /// <param name="age"></param>
        public static void DescribeAnimal(string name, string species, int age)
        {
            DescribeAnimal(name, species);
            Console.WriteLine($"Animal Age: {age} years old");
        }
    }
}
