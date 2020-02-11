using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraMatrices
{
    public class Menu
    {
        public static void MuestraMenu(int[,] matriz1, int [,] matriz2, int tamanio) //El método recibe las dos matrices generadas y el tamaño de estas
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ahora que ya está configurada la matriz, ¿qué operación deseas realizar?");
                Console.WriteLine("(S)umar matriz");
                Console.WriteLine("(R)estar matriz");
                Console.WriteLine("(M)ultiplicar matriz");
                Console.WriteLine("(E)Salir");
                Console.Write("Ingresa una opción: ");
                char opcion = Convert.ToChar(Console.ReadLine()); //Se hace un cast para validar que sólo se ingrese una letra
                switch (char.ToUpper(opcion)) //Se hace un cast a upper para contemplar minúsculas y mayusculas
                {
                    case 'S':
                        Calculadora.CalcularMatriz(matriz1, matriz2, 1, tamanio); //El número 1 representa suma
                        break;
                    case 'R':
                        Calculadora.CalcularMatriz(matriz1, matriz2, 2, tamanio); //El número 2 representa resta
                        break;
                    case 'M':
                        Calculadora.CalcularMatriz(matriz1, matriz2, 3, tamanio); //El número 3 representa multiplicación
                        break;
                    case 'E':
                        Console.WriteLine("Ejecución terminada");
                        Console.ReadKey();
                        break;
                    default:
                        throw new SwitchException("Ingresa una opción válida");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingrese una opción válida");
                Console.ReadKey();
                MuestraMenu(matriz1, matriz2, tamanio);
            }
            catch (SwitchException se)
            {
                Console.WriteLine(se.Message);
                Console.ReadKey();
                MuestraMenu(matriz1, matriz2, tamanio);
            }
        }

    }
}