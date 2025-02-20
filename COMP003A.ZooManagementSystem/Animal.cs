namespace COMP003A.ZooManagementSystem
{
    internal abstract class Animal
    {
        //fields
        private string _name;
        private string _species;

        //properties



        public string Name
        {
            get { return _name; }
            set {
                if (string.IsNullOrWhiteSpace(_name)) ;
                else
                {
                    _name = value;
                }
            }
        }
        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrWhiteSpace(_species)) ;
                else
                {
                    _species = value;
                }
            }
        }
        //will display "sound"
        public abstract void MakeSound();
    }
}
