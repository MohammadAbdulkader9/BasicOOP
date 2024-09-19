using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.Error
{
    internal class NegInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a negative input in a positive-only field. This fired an error!";
        }
    }
}
