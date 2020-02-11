using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraNormal
{
    class RangoException : Exception
    {
        public RangoException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
    class SwitchException : Exception
    {
        public SwitchException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
}
