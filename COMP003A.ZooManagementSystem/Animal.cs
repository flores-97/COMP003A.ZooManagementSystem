namespace COMP003A.ZooManagementSystem
{
    internal abstract class Animal
    {
        //fields
        private string _name;
        private string _species;

        //properties
        public string Name { get; set; }
        public string Species { get; set; }

        //will display "sound"
        public abstract void MakeSound();
    }
}
