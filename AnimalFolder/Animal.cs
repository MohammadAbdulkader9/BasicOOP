using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight},";
        }
        public abstract void DoSound();
        
    }
}

//14. F. nya attributer för alla djur ska läggas i Animal klassen för att alla djur ärver från Animal
