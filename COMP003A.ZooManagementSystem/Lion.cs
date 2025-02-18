﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    class Lion : Animal
    {
        //auto implement property
        public string Name { get; set; }
        public string Species { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public Lion(string name, string species) 
        {
            Name = name;
            Species = species;
        }


        public override void MakeSound()
        {
            Console.WriteLine("The lion roars!");
        }
    }
}
