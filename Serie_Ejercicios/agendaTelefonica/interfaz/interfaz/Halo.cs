using System;
using System.Collections.Generic;
using System.Text;

namespace interfaz
{
    class Halo : IVideojuego
    {
        public void Jugar() 
        {
            Console.WriteLine("Primera persona");
        }
        public void Objetivo() 
        {
            Console.WriteLine("Salvar al universo de la amenaza covenant");
        }
    }
}
