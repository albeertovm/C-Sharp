using System;
using System.Collections.Generic;
using System.Text;

namespace claseCarro
{
    class Carro
    {
        private double peso; //No se ocupa debido a que no hay validacione simplementadas
        public double Peso 
        {
            get { return peso; } //Métodos get y set
            set { peso = value; } 
        }
        private double altura; //No se ocupa debido a que no hay validacione simplementadas
        public double Altura 
        { get { return altura; }
            set { altura = value; } 
        }
        private bool encendido;
        public bool Encendido 
        {
            get { return encendido; }
            set { encendido = false; } 
        }
        public Carro(double peso, double altura)  //Constructor
        {
            Peso = peso;
            Altura = altura;
        }
        public void Encender() 
        {
            encendido = true; //Se cambia el valor a true
            Console.WriteLine("Ecendiendo auto...");
        }
        public void Apagar() 
        {
            encendido = false; //Se cambia el valor a false
            Console.WriteLine("Apagando auto...");
        }
        public void Estado() {
            if (encendido) //Se valida el valor del campo encendido
            {
                Console.WriteLine("Encendido");
            }
            else
            {
                Console.WriteLine("Apagado");
            }
        }
        public override string ToString()
        {
            return string.Format("El peso es de {0}kg y la altura de {1}mts", peso, altura);
        }
    }
}
