using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {


Console.WriteLine("Select an animal:");
            Console.WriteLine("1.Pig");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Bird");
            Console.WriteLine("4. Cat");
            Console.WriteLine("Press any key to exit.: ");
            
            bool IsRunning = true;
            
            while(IsRunning == true) { 
            Console.WriteLine("Which animal do you want to hear?");
            var choice = Console.ReadLine();

            Animal animal = null;

            if (choice == "1")
            {
                animal = new Pig();
                animal.MakeNoise();
                animal.Sleep();
            
            }
            else if       (choice == "2")
            {
                animal = new Dog();
                animal.MakeNoise();
                animal.Sleep();
            }
            else if (choice == "3")
            {
                animal = new Bird();
                animal.MakeNoise();
                animal.Sleep();
            }
           else if (choice == "4")
            {
                animal = new Cat();
                animal.MakeNoise();
                animal.Sleep();
            }
            else { 
            IsRunning = false;
                
                Console.WriteLine("Bye bye!");
            }
                }
}
        }
    }