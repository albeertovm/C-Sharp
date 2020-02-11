using System;
using System.Collections.Generic;
using System.Text;

namespace nNumerosNaturales
{
    class NaturalesException : Exception
    {
        public NaturalesException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
}
