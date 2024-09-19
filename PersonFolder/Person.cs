using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.PersonFolder
{

    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double? height;
        private double? weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) // validating age
                {
                    throw new ArgumentException("Age must be grater than 0.");
                }
                age = value;
            }
        }

        public string Fname
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10) // validating first name
                {
                    throw new ArgumentException("First name can't be less than 2 or greater than 10");
                }
                fName = value;                
            }

        }
        public string Lname
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15) // validating last name
                {
                    throw new ArgumentException("Last name can't be less than 3 or greater than 15");
                }
                lName = value;                                
            }
        }
        public double? Height { get; set; }
        public double? Weight { get; set; }
    }
}

//F. nej, för att fielden är private, då behöver vi använda get och set methods
