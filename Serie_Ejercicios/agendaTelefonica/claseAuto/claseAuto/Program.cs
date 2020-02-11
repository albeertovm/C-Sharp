using System;

namespace claseAuto
{
    class Program
    {
        static void Main()
        {
            Auto a1 = new Auto("Audi", "A7", 63);
            Auto a2 = new Auto("Audi", "Q8");
            Auto a3 = new Auto("Tesla", "X");
            //Métodos
            a1.Encender();
            a2.Frenar();
            a3.Acelerar(); 
            //Método set
            a3.Kilometraje = 12.23;
            a3.Color = "Gris";
            //Método get
            Console.WriteLine("Auto: {0} Color: {1} Kilometraje: {2}", a3.Marca, a3.Color, a3.Kilometraje);
            Console.ReadKey();
        }
    }
}
