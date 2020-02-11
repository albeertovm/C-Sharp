using System;
using System.Collections.Generic;
using System.Text;

namespace pilaresPOO
{
    class Relojes
    {
        //Encapsulamiento al proteger los datos para solo la clase y sus derivados
        protected string Material { get; } //Encapsulamiento
        protected string Fabricante { get; } //Encapsulamiento
        protected float Precio { get; set; } //Encapsulamiento
        protected Relojes(string material, string fabricante, int precio)  //Abstracción
        {
            Material = material;
            Fabricante = fabricante;
            Precio = precio;
        }
        public virtual void MostrarDatos() //Polimorfismo
        {
            Console.WriteLine("Material: {0} Fabricante: {1} Precio: {4}", Material, Fabricante, Precio);
        }
    }
}