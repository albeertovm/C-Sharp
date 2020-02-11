using System;
using System.Collections.Generic;
using System.Text;

namespace interfaz
{
    class Minecraft : IVideojuego
    {
        public void Jugar() 
        {
            Console.WriteLine("Primera persona");
        }
        public void Objetivo() 
        {
            Console.WriteLine("Pasar el rato");
        }
    }
}
