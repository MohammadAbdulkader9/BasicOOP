using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    internal class AnimalProgram
    {
        public static void Run()
        {
            Console.WriteLine(
                "Animal Program\n" +
                "--------------");

            List<Animal> animals = new List<Animal>()
            {
            new Dog("Doggie", 20, 5, true),
            new Horse("Horsie", 120, 6, false),
            new Wolf("Wolffie", 99, 7, true),
            new Bird("Birdie", 5.5, 1, false),
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();

                if (animal is IPerson person)
                {
                    person.Talk();
                }
                // 13. F. i denna loopen skrivs ut varje djur och deras stats samt deras ljud.
            }

            //create Swan
            Swan swan = new Swan("Swanie", 2, 4, false, true);
            Console.WriteLine(swan.Stats());
            swan.DoSound();

            //create Dog List
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Dogsie", 34, 5, true),
               // new Horse("Horsman", 88, 1, false), //Error
               // 8. F. det går inte att lägga till Horse i Dog listan för att denna lista tar bara in Dog Type.
               // 9. F. Listan måste vara Animal för att lägga till olika djur. ex. List<Animal> animals = new List<Animal>()
            };

            // bara dog stats i Animal listan
            Console.WriteLine("- Dog Stats in Animal List: ");
            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }

            // för att komma åt Sit metoden i Dog klassen genom Animal listan
            foreach (Animal animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.Sit());
                }
            }
            // 16&17. F. du kan inte komma åt metoden Sit genom Animal listan direkt.
            // det beror på att listan är type Animal och Sit metoden behöver Dog typen för att komma åt den.
        }
    }
}
