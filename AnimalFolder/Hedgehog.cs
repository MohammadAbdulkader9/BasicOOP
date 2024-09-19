using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    internal class Hedgehog : Animal
    {        
        public bool IsCute;
        public Hedgehog(string name, double weight, int age, bool isCute ) : base(name, weight, age)
        {   
            IsCute = isCute;
        }

        public override string Stats()
        {
            return base.Stats() + $" is cute: {IsCute}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Grunt");
        }
    }
}
