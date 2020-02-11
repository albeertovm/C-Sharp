using System;

namespace claseCarro
{
    class Program
    {
        static void Main()
        {
            BMW bmw1 = new BMW(500, 1.50) { Modelo = "i8 Coupé" }; //Se instancia el objeto
            Console.WriteLine(bmw1.ToString());
            bmw1.Estado();
            bmw1.Encender();
            bmw1.Estado();
            bmw1.Apagar();
            bmw1.Estado();
            Tesla t1 = new Tesla(1000, 1.40) { Modelo = "X" }; //Se instancia el objeto
            Console.WriteLine(t1.ToString());
            t1.Estado();
            t1.Encender();
            t1.Estado();
            t1.Apagar();
            t1.Estado();
            Console.ReadKey();
        }
    }
}
