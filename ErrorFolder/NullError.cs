using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.Error
{
    internal class NullError : UserError
    {
        public override string UEMessage()
        {
            return "You left the field empty. This fired an error!";
        }

    }
}
