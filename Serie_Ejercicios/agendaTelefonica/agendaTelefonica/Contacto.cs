using System;
using System.Collections.Generic;
using System.Text;

namespace agendaTelefonica
{
    class Contacto
    {
        private string Nombre { set; get; }
        private string Telefono { set; get; }
        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

    }
}
