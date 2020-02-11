using System;
using System.Collections.Generic;
using System.Text;

namespace pilaresPOO
{
    class Digital : Relojes, IReloj //Herencia
    {
        private string Formato { get; } //Encapsulamiento
        private string Profundidad { get; } //Encapsulamiento
        public Digital(string material, string fabricante, int precio, string formato, string profundidad) : base(material, fabricante, precio)//Abstracción
        {
            Formato = formato;
            Profundidad = profundidad;
        }
        public void MostrarHora()//Polmorfismo
        {
            Console.WriteLine("Hora: Leer pantalla/Escuchar hora");
        }
        public override void MostrarDatos()
        {
            Console.WriteLine("Material: {0} Fabricante: {1} Precio: {2} Formato: {3} Profundidad: {4}", Material, Fabricante, Precio, Formato, Profundidad);//Polimorfismo
        }
    }
}
