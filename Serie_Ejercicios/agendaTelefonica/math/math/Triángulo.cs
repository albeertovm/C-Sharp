using System;
using System.Collections.Generic;
using System.Text;

namespace math
{
    class Triángulo
    {
        public double Base {get;set;}
        public double Altura { get; set; }
        public double CalculaArea(double _base, double altura)
        {
            double numero = (_base * altura) / 2;
            //Math.Truncate devuelve solo la parte entera de un número
            return Math.Truncate(numero);
        }
    }
}
