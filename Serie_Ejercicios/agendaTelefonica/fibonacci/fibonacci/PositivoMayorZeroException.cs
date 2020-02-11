using System;
using System.Collections.Generic;
using System.Text;

namespace fibonacci
{
    class PositivoMayorZeroException : Exception
    {
        public PositivoMayorZeroException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
}
