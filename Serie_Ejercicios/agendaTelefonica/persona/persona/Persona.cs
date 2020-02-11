using System;
using System.Collections.Generic;
using System.Text;

namespace persona
{
    class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private double Estatura { get; set; }
        private double Peso { get; set; }
        public Persona(string nombre, int edad, double estatura, double peso) {
            Nombre = nombre;
            Edad = edad;
            Estatura = estatura;
            Peso = peso;
        }
        public void Saludar () 
        {
            Console.WriteLine("{0} dice hola", Nombre);
        }
        public void MostrarDatos() {
            Console.WriteLine("{0} tiene {1} años, mide {2}mts y pesa {3}kgs", Nombre, Edad, Estatura, Peso);
        }
        public void Aprobar()
        {
            Console.WriteLine("{0} acaba de aprobar el curso de C# con 10", Nombre);
        }
    }
}