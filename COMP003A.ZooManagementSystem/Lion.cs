namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public Lion(string Name, string Species) 
        {
            Name = Name;
            Species = Species;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The lion roars! ({Name}, {Species})");
        }
    }
}
