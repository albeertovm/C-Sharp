using System;
using System.Collections.Generic;
using System.Text;

namespace math
{
    class Circulo
    {
        public double Radio { set; get; }
        public double CalcularArea(double radio) {
            //Math.PI representa la constante e PI
            //Math.Pow regresa un numero elevado a la n potencia
            return Math.Pow(radio , 2) * Math.PI;
        }
    }
}