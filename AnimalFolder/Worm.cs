using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    internal class Worm : Animal
    {        
        public bool IsPoisonous;

        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override string Stats()
        {
            return base.Stats() + $" is poisonous: {IsPoisonous}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Hiss");
        }
    }
}
