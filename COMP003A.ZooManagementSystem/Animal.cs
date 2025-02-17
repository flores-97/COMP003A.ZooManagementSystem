using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    class Animal
    {
        //fields
        private string _name;
        private string _species;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }
        //will display "sound"
        public virtual void MakeSound()
        {
            Console.WriteLine(MakeSound);
        }


    }
}
