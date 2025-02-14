using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{

    /// <summary>
    /// represents animal abstract class
    /// </summary>
    abstract class Animal
    {
        //fields
        private string _name;
        private string _species;
        private string _makesound;

        //properties

        /// <summary>
        /// abstract method for name and species
        /// </summary>
        public string Name { get; set; }
        public string Species { get; set; }
        public string Makesound { get; set; }


        /// <summary>
        /// represents sound abstract method 
        /// </summary>
        class MakeSound();
    }  
}
