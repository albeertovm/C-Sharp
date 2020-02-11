using System;
using System.Collections.Generic;
using System.Text;

namespace pilaresPOO
{
    class Automatico : Relojes, IReloj //Herencia
    {
        private string Formato { get; }
        public Automatico(string material, string fabricante, int precio, string formato) : base (material, fabricante, precio) //Abstracción
        {
            Formato = formato;
        }
        public void MostrarHora() //Polimorfismo
        {
            Console.WriteLine("Hora: Leer manecillas");
        }
        public override void MostrarDatos()
        {
            Console.WriteLine("Material: {0} Fabricante: {1} Precio: {2} Formato: {3}", Material, Fabricante, Precio, Formato); //Polimorfismo
        }
    }
}
