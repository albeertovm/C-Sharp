using System;
using System.Collections.Generic;
using System.Text;

namespace fVocal
{
    class VocalesException : Exception
    {
        public VocalesException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento

    }
}
