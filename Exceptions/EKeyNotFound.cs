using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork28.Exceptions
{
    internal class EKeyNotFound : Exception
    {
        public EKeyNotFound(string message)
            : base(message)
        {
        }
    }
}
