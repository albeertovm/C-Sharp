using System;
using System.Collections.Generic;
using System.Text;

namespace interfaz
{
    class LeagueofLegends : IVideojuego
    {
        public void Jugar() 
        {
            Console.WriteLine("Tercera persona");
        }
        public void Objetivo() 
        {
            Console.WriteLine("Destruir el nexo enemigo");
        }
    }
}
