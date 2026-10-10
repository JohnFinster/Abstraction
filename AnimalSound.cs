using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTutorial
{
    class Cat : Animal // Animal is a derived abstract class
    {
        // 'override' must be used to implement the abstract method in the derived class
        public override void AnimalSound() // animalSound() body provided here
        {
            Console.WriteLine("What sound does the cat make?");
            string sound = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nThe cat says: " + sound + ".");
        }
    }

    class Dog : Animal // Animal is a derived abstract class
    {
        // must use 'override'  to implement abstract method in the derived class
        public override void AnimalSound() // animalSound() body provided here
        {
            Console.WriteLine("\nWhat sound does the dog make?");
            string sound = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nThe dog says: " + sound + ".");
        }
    }

    class Pig : Animal // Animal is a derived abstract class
    {
        public override void AnimalSound() // animalSound() body provided here
        {
            Console.WriteLine("\nWhat sound does the pig make?");
            string sound = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nThe pig says: " + sound + ".");
        }
    }
}


