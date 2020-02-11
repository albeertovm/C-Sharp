using System;
using System.Collections.Generic;
using System.Text;

namespace becarioMart
{
    class SwitchException : Exception
    {
        public SwitchException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
}
