// Author: Victor Flores
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Animal> animals = new List<Animal>();

            Lion lion = new Lion();
            animals.Add(lion);

            Parrot parrot = new Parrot();
            animals.Add(parrot);


            Console.WriteLine("Welcome to the Zoo Management System!");

            int choice;
            int done;

            while (true)
            {
                Console.WriteLine("\nInventory Management System Menu: \n");
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
                            Console.Write("\nEnter the name of the lion: ");
                            string Name = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(Name)) throw new Exception("\nLion's name cannot be blank.");
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
                            if (string.IsNullOrWhiteSpace(Species)) throw new Exception("\nSpecies cannot be blank.");
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
                            Console.Write("\nEnter the name of the Parrot: ");
                            string Name = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(Name)) throw new Exception("\nParrot's name cannot be blank.");
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
                            if (string.IsNullOrWhiteSpace(Species)) throw new Exception("\nSpecies cannot be blank.");
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
                    foreach (Animal animal in animals)
                    {
                        animal.MakeSound();
                    }
                }
                else if (choice == 4)
                {
                    ZooUtility.DescribeAnimal("Simba");
                    ZooUtility.DescribeAnimal("Polly", "Psittaciformes");
                    ZooUtility.DescribeAnimal("Charlie", "Elephant", 12);

                }

                else
                {
                    Console.WriteLine("\nInvalid entry. Select an option on the menu.\n");
                }
            }

        }//ends program

        
    }
}
