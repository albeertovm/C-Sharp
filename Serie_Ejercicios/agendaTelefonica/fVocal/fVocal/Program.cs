using System;
using System.Linq;

namespace fVocal
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Este programá agregará una f antes de cada vocal de una cadena que ingreses");
                Console.Write("Ingresa tu cadena: ");
                string cadena = Console.ReadLine();
                Console.WriteLine(Agregaf(cadena)); //Se imprime la nueva cadena que retorna la función Agregaf
                Console.WriteLine("Ingrese (Esc) para salir o cualquier otra tecla para volver a ejecutar el programa");
                if (Console.ReadKey().Key == ConsoleKey.Escape) //Si se ingresa la tecla Esc cuando se solicita, se termina la ejecución del programa de lo contrario continua ejecutándose
                {
                    Environment.Exit(0); //Termina la ejecución del programa
                }
                else
                {
                    Main(); //Se vuelve a ejecutar el método main
                }
            }
            catch (VocalesException ve)
            {
                Console.WriteLine(ve.Message);
                Console.WriteLine("Ingrese (Esc) para salir o cualquier otra tecla para volver a ejecutar el programa");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Main();
                }
            }
        }
        public static string Agregaf(string cadena)
        {
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }; //Arreglo para saber si se han ingresado vocales
            string nuevaCadena = "";
            foreach(char letra in cadena)
            {
                if (vocales.Contains(letra)) //Se verifica si algun elemento del arreglo vocales contiene el elemento iterado de la cadena ingresada por el usuario
                {
                    nuevaCadena += "f" + letra; //Se agrega una f si el elemento iterado se encuentra en el arreglo de vocales
                }
                else
                {
                    nuevaCadena += letra; //De lo contrario pasa sin modficaciones
                }
            }
            if (cadena != nuevaCadena) { //Se verifica que se haya ingresado por lo menos una vocal
                return nuevaCadena;
            }
            else
            {
                throw new VocalesException("No se han ingresado vocales");
            }
        }
    }
}