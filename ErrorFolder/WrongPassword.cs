using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.Error
{
    internal class WrongPassword : UserError
    {
        public override string UEMessage()
        {
            return "Wrong password entered. Try again!";
        }
    }
}
