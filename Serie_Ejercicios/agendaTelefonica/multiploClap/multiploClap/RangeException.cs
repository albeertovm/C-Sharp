using System;
using System.Collections.Generic;
using System.Text;

namespace multiploClap
{
    class RangeException : Exception
    {
            public RangeException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
}