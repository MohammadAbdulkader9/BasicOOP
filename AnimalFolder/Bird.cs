using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.AnimalFolder
{
    public class Bird : Animal
    {        
        public bool IsFast;
        public Bird(string name, double weight, int age, bool isFast) : base(name, weight, age)
        {   
            IsFast = isFast;
        }

        public override string Stats()
        {
            return base.Stats() + $" is fast: {IsFast},";
        }

        public override void DoSound()
        {
            Console.WriteLine("Whistle");
        }
    }

    public class Pelican : Bird
    {
        public bool CanSing;
        public Pelican(string name, double weight, int age, bool isFast, bool canSing) : base(name, weight, age, isFast)
        {
            CanSing = canSing;
        }

        public override string Stats() {
            return base.Stats() + $" can sing: {CanSing}, ";
        }
    }

    public class Flamingo : Bird
    {
        public bool CanFly;
        public Flamingo(string name, double weight, int age, bool isFast, bool canFly) : base(name, weight, age, isFast)
        {
            CanFly = canFly;
        }

        public override string Stats()
        {
            return base.Stats() + $" can fly: {CanFly}";
        }
    }

    public class Swan : Bird
    {
        public bool CanSwim;
        public Swan(string name, double weight, int age, bool isFast, bool canSwim ) : base(name, weight, age, isFast)
        {
            CanSwim = canSwim;  
        }

        public override string Stats()
        {
            return base.Stats() + $" can swim: {CanSwim}";
        }
    }
}
//13. F. vi bör lägga till nya attributer i Bird klassen för att fåglarna ärver från Bird.

