using BasicOOP.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.ErrorFolder
{
    internal class ErrorProgram
    {
        public static void Run() 
        {
            Console.WriteLine(
                "Error Program\n" +
                "-------------");

            List<UserError> userErrors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new NullError(),
                new NegInputError(),
                new WrongPassword()

                };

            foreach (var er in userErrors)
            {
                Console.WriteLine(er.UEMessage());
            }
        }
    }
}
