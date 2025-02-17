// Author: Victor Flores
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
using Microsoft.VisualBasic;

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            List<Animal> animals = new List<Animal>();

            List<Lion> myLion = new List<Lion>();
            List<Parrot> myParrot = new List<Parrot>();

            ZooUtility utility = new ZooUtility();

            Console.WriteLine("Welcome to the Zoo Management System!");


            int choice;
            int done;

            while (true)
            {
                Console.WriteLine("\nInventory Management System Menu: ");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());



                if (choice == 5) break;

                else if (choice == 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the name of the lion: ");
                            string Name = Console.ReadLine();
                               
                            if (string.IsNullOrWhiteSpace(Name))  throw new Exception("Lion's name cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                        
                    }
                    

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the species of the lion: ");
                            string Species = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(Species)) throw new Exception("Species cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    Console.WriteLine("Lion added successfully!");
                }

                else if (choice == 2)
                {

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the name of the Parrot: ");
                            string Name = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(Name)) throw new Exception("Parrot's name cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter the species of the Parrot: ");
                            string Species = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(Species)) throw new Exception("Species cannot be blank.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                        }
                    }

                    Console.WriteLine("Parrot added successfully!");
                }


                else if (choice == 3)
                {//this area needs work 
                    Console.WriteLine("\nDisplaying all Animals:");
                    Console.WriteLine($"{animal.MakeSound} {myLion}");
                    Console.WriteLine($"{animal.MakeSound} {myParrot}");
                }

                else if (choice == 4)
                {
                    Console.WriteLine(utility);//will display all of animals description
                }

                else
                {
                    Console.WriteLine("\nInvalid entry. Select an option on the menu.\n");
                }
            }

        }//ends program

        
    }
}
