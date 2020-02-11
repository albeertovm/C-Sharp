using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics; 

namespace numeroComplejo
{
    class NumeroComplejo
    {
        private int ParteReal { get; set; }
        private int ParteImaginaria { get; set; }
        public NumeroComplejo(int real, int imaginaria) 
        {
        ParteReal = real;
        ParteImaginaria = imaginaria;
        }
        public void Imprimir() 
        {
            if (ParteImaginaria > 0) //Si la parte imaginaria es un número positivo se escribe con formato Real+Imaginarioi
            {
                Console.WriteLine("{0}+{1}i", ParteReal, ParteImaginaria);
            }
            else if (ParteImaginaria == 0) //Si la parte imaginaria es igual a cero sólo se escribe la parte real
            {
                Console.WriteLine("{0}", ParteReal);
            }
            else //Si la parte imaginaria es negativa se escribe con formato RealImaginarioi
            {
                Console.WriteLine("{0}{1}i", ParteReal, ParteImaginaria);
            }
        }
        public NumeroComplejo Suma(NumeroComplejo numero)
        {
            NumeroComplejo suma = new NumeroComplejo(this.ParteReal + numero.ParteReal, this.ParteImaginaria + numero.ParteImaginaria); /*Realiza la suma de la ParteReal y ParteImaginaria de la instancia y de la 
                                                                                                                                        ParteReal y ParteImaginaria del segundo número que se pasa como parámetro*/
            return suma;
        }
    }
}
