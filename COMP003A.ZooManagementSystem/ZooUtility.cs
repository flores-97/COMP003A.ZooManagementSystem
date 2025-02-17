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
            return DescribeAnimal($"Animal Name: {name}");
        }

        /// <summary>
        /// display animal name and species
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        /// <returns></returns>
        public string DescribeAnimal(string name, string species)
        {
            return DescribeAnimal($"Animal Name: {name}, Species: {species}");
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
            return DescribeAnimal($"Animal Name: {name}, Species: {species}, Age: {age} years old");
        }
    }
}
