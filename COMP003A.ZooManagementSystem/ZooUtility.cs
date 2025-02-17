using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class ZooUtility
    {
        /// <summary>
        /// display animal name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string DescribeAnimal(string name)
        {
            Console.WriteLine(name);
        }

        /// <summary>
        /// display animal name and species
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        /// <returns></returns>
        public string DescribeAnimal(string name, string species)
        {
            Console.WriteLine(name, species);
        }

        /// <summary>
        /// display name, species, and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public string DescribeAnimal(string name, string species, int age)
        {
            Console.WriteLine(name, species, age);
        }
    }
}
