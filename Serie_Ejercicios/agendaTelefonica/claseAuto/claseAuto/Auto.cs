using System;
using System.Collections.Generic;
using System.Text;

namespace claseAuto
{
    class Auto
    {
        //Propiedades
        public string Marca { get; }
        public string Color { set; get; }
        public string Modelo { get; }
        public int Capacidad { set;get; }
        public double Kilometraje { set; get; }
        //Constructor por defecto
        public Auto(string marca, string modelo, int capacidad)
        {
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
        }
        //Sobrecarga de constructor por número de parámetros recibidos
        public Auto(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        //Métodos
        public void Encender() {
            Console.WriteLine("{0} {1}: El auto se ha encendido...", Marca, Modelo);
        }
        public void Acelerar() {
            Console.WriteLine("{0} {1}: Aumentando velocidad...", Marca, Modelo);
        }
        public void Frenar() {
            Console.WriteLine("{0} {1}: Reduciendo velocidad...", Marca, Modelo);
        }
    }
}
