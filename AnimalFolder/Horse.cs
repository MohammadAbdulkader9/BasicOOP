using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    internal class Horse : Animal
    {
        
        public bool IsAggresive;

        public Horse(string name, double weight, int age, bool isAggresive) : base(name, weight, age)
        {
            
            IsAggresive = isAggresive;
        }

        public override string Stats()
        {
            return base.Stats() + $" is aggresive: {IsAggresive}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }
    }
}
