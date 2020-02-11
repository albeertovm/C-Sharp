using System;
using System.Collections.Generic;
using System.Text;

namespace persona
{
    class NumerosException : Exception
    {
        public NumerosException(string Mensaje) : base(Mensaje) { }
    }
}
