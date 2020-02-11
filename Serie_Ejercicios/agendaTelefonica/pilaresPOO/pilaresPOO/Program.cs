using System;

namespace pilaresPOO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Reloj automático:");
            Automatico a1 = new Automatico("Acero", "Seiko", 2000, "Analógico");
            a1.MostrarHora();
            a1.MostrarDatos();
            Console.WriteLine("Reloj digital:");
            Digital d1 = new Digital("Resina", "Casio", 1000, "Digital", "100mts");
            d1.MostrarHora();
            d1.MostrarDatos();
            Console.ReadKey();
        }
    }
}
