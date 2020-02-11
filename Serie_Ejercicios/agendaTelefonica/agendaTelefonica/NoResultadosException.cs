using System;
using System.Collections.Generic;
using System.Text;

namespace agendaTelefonica
{
    class NoResultadosException : Exception
    {
        public NoResultadosException(string Mensaje) : base(Mensaje) { } //Envía el mensaje de error ingresado como argumento
    }
}
