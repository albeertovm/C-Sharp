using System;

namespace numeroComplejo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Números complejos: ");
            NumeroComplejo nc1 = new NumeroComplejo(5,10);
            NumeroComplejo nc2 = new NumeroComplejo(7,0);
            NumeroComplejo nc3 = new NumeroComplejo(3,-5);
            nc1.Imprimir();
            nc2.Imprimir();
            nc3.Imprimir();
            Console.WriteLine("Suma de dos números complejos: ");
            NumeroComplejo nc4 = nc1.Suma(nc3); //Suma de números complejos
            nc4.Imprimir();
           
        }
    }
}