using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    internal class Wolf : Animal
    {        
        public bool IsScary;
        public Wolf(string name, double weight, int age, bool isScary) : base(name, weight, age)
        {            
            IsScary = isScary;
        }

        public Wolf(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string Stats()
        {
            return base.Stats() + $" is scary: {IsScary}" ;
        }

        public override void DoSound()
        {
            Console.WriteLine("Yelp");
        }
    }
}
