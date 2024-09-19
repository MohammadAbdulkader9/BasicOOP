using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.PersonFolder
{
    internal class PersonHandler
    {
        public static Person CreatePerson()
        {
            Person person = new Person();
            return person;
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                Fname = fname,
                Lname = lname,
                Height = height,
                Weight = weight
            };
            return person;
        }       

        public void SetFirstName(Person person, string fname)
        {
            person.Fname = fname;
        }
        public void SetLastName(Person person, string lname)
        {
            person.Lname = lname;
        }
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }
        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }
        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }
    }
}
