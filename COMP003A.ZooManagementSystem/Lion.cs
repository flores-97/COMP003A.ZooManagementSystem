using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    class Lion : Animal
    {
        public Lion() 
        {
            Name = "Lion";
            Species = "Panthera leo";
        }
        public override void MakeSound()
        {
            Console.WriteLine("The lion roars!");
        }
    }
}
