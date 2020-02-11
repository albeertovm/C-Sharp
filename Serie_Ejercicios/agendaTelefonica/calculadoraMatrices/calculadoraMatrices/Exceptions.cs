using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraMatrices
{
    class ValorException : Exception
    {
        public ValorException(string Mensaje) : base(Mensaje) { }
    }
    class TamanoException : Exception
    {
        public TamanoException(string Mensaje) : base(Mensaje) { }
    }
    class SwitchException : Exception
    {
        public SwitchException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
}
