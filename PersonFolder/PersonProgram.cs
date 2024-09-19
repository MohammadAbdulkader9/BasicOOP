using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.PersonFolder
{
    internal class PersonProgram
    {
        public static void Run()
        {
            Console.WriteLine(
                "Person Program\n" +
                "--------------");

            PersonHandler personHandler = new PersonHandler();
            // Person pers = new Person();

            Person personOne = personHandler.CreatePerson(
                age: 25,
                fname: "Mohammad",
                lname: "Abdulkader",
                height: 173,
                weight: 70
                );

            Console.WriteLine($"- Person one Added: {personOne.Fname} {personOne.Lname}, age: {personOne.Age}, Height: {personOne.Height} and Weight: {personOne.Weight}");

            personHandler.SetAge(personOne, age: 30);
            Console.WriteLine("* Age changed");

            personHandler.SetFirstName(personOne, fname: "Adam");
            Console.WriteLine("* First name changed");

            Console.WriteLine($"- Person one changed: {personOne.Fname} {personOne.Lname}, age: {personOne.Age}, Height: {personOne.Height} and Weight: {personOne.Weight} ");


            Person personTwo = PersonHandler.CreatePerson();

            personHandler.SetFirstName(personTwo, "Jones");
            personHandler.SetLastName(personTwo, "Mike");
            personHandler.SetAge(personTwo, 55);
            personHandler.SetHeight(personTwo, 177);
            personHandler.SetWeight(personTwo, 77);

            Console.WriteLine("Person two created");
            Console.WriteLine($"- Person two Added: {personTwo.Fname} {personTwo.Lname}, age: {personTwo.Age}, Height: {personTwo.Height} and Weight: {personTwo.Weight}");

            try
            {
                Person testPerson = new Person();
                // testPerson.Age = -5;
                // testPerson.Fname = "M";
                // testPerson.Lname = "AB";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }
    }
}
