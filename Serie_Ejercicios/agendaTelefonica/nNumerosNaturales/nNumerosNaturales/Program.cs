using System;

namespace nNumerosNaturales
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Clear(); //Limpia la pantalla en cada llamada al método
                Console.WriteLine("Este programa calculará la suma de n números naturales");
                Console.Write("Ingresa hasta qué numero natural deseas realizar la suma: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                //FormatException, NaturalesException
                Console.WriteLine("La suma realizada hasta el número {0} es {1}", numero, Suma(numero)); //Imprime la suma
                Console.WriteLine("Ingrese (Esc) para salir o cualquier otra tecla para volver a ejecutar el programa");
                if (Console.ReadKey().Key == ConsoleKey.Escape) //Si se ingresa la tecla Esc se termina la ejecución del programa, de lo contario se sigue ejecutando
                {
                    Environment.Exit(0); //Termina la ejecución del programa 
                }
                else
                {
                    Main();
                }
            }
            catch (FormatException fe) //Recibe en error de haber ingresado algo que no es un número
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingrese un número");
                Console.WriteLine("Ingrese (Esc) para salir o cualquier otra tecla para volver a ejecutar el programa");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Main();
                }
            }
            catch (NaturalesException ne)
            {
                Console.WriteLine(ne.Message);
                Console.WriteLine("Ingrese (Esc) para salir o cualquier otra tecla para volver a ejecutar el programa");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Main();
                }
            }
        }
        public static int Suma(int numero) {
            if (numero > 0) //Valida que el número ingresado sea natural, es decir, no negativo mayor a 0
            {
                int suma = 0;
                while (numero != 0) //Realiza la iteración hasta que se llegue al número predecesor 0
                {
                    suma += numero; //Realiza la suma del número ingresado
                    numero -= 1; //Le resta 1 al número ingresado en cada iteración para conocer a sus predecesores
                }
                return suma;
            }
            else
            {
                throw new NaturalesException("Ese no es un número natural");
            }
        }
    }
}
