using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraMatrices
{
    public class Calculadora
    {
        public static void CalcularMatriz(int[,] matriz1, int[,] matriz2, int operacion, int tamanio) //El método recibe las dos matrices generadas, el tamaño de estas y el ID de la operación a realizar (+,-,*)
        {
            int[,] matriz3 = new int[tamanio, tamanio]; //Se define una matriz vacía para almacenar el resultado de operar las dos matrices configuradas
            for (int renglon = 0; renglon < tamanio; renglon++) //Se itera cada renglón
            {
                for (int columna = 0; columna < tamanio; columna++) //Se itera cada columna
                {
                    if (operacion == 1) //Se verifica el ID de cada operación
                    {
                        matriz3 [renglon, columna] = matriz1[renglon, columna] + matriz2[renglon, columna]; //Se operan los valores "espejo" de las dos matrices y se asignan a la matriz vacía
                    }
                    else if (operacion == 2)
                    {
                        matriz3[renglon, columna] = matriz1[renglon, columna] - matriz2[renglon, columna];
                    }
                    else if (operacion == 3)
                    {
                        matriz3[renglon, columna] = matriz1[renglon, columna] * matriz2[renglon, columna];
                    }
                }
            }
            ImprimeMatriz(matriz3, tamanio);
            Menu.MuestraMenu(matriz1, matriz2, tamanio); //Se llama al método MuestraMenu
        }
        public static void ImprimeMatriz(int[,] matriz3, int tamanio)
        {
            for (int renglon = 0; renglon < tamanio; renglon++)
            {
                for (int columna = 0; columna < tamanio; columna++)
                {
                    Console.Write(matriz3[renglon, columna] + "\t"); //Se imprime cada elemento de la matriz resultante a la operación
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
