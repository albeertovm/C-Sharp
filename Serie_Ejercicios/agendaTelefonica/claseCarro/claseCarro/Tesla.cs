using System;
using System.Collections.Generic;
using System.Text;

namespace claseCarro
{
    class Tesla : Carro
    {
        private string modelo; //No se ocupa debido a que no hay validacione simplementadas
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public Tesla(double peso, double altura) : base(peso, altura) { } //Constructor heredado
        public override string ToString()
        {
            return string.Format("Modelo {0}: el peso es de {1}kgs y la altura de {2}mts", modelo, Peso, Altura);
        }
    }
}
