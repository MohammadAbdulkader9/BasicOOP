using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    internal class Dog : Animal
    {
        public bool IsFriendly;
        public Dog(string name, double weight, int age, bool isFriendly) : base(name, weight, age)
        {            
            IsFriendly = isFriendly;
        }

        public override string Stats()
        {
            return base.Stats() + $" is friendly: {IsFriendly}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Bark");
        }

        public string Sit()
        {
            return $"{Name} Sitting";
        }
    }
}
