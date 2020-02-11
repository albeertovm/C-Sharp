using System;

namespace calculadoraMatrices
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Este programa es una calculadora de matrices cuadradas");
            Console.WriteLine("Primero debes crear las matrices, solo se permiten matrices de dimensiones entre 2 y 9");
            Console.Write("Ingresa el tamaño de la matriz cuadrada: ");
            try
            {
                int tamanio = Convert.ToInt32(Console.ReadLine());
                if (tamanio > 1 && tamanio < 9)
                {
                    //Se declaran 2 matrices de dos dimensiones vacías
                    int[,] matriz1 = new int[tamanio, tamanio];
                    int[,] matriz2 = new int[tamanio, tamanio];
                    matriz1 = GeneraMatriz(matriz1, tamanio); //Se agregan los valores a las matrices
                    matriz2 = GeneraMatriz(matriz2, tamanio);
                    Menu.MuestraMenu(matriz1, matriz2, tamanio); //Se manda a llamar el método MostrarMenu
                }
                else
                {
                    throw new TamanoException("La matriz solo puede tener un tamaño entre 2 y 9");
                }
            }
            catch (TamanoException te)
            {
                Console.WriteLine(te.Message);
                Console.ReadKey();
                Main();
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingrese sólo un número entero");
                Console.ReadKey();
                Main();
            }
        }
        public static int[,] GeneraMatriz(int[,] matriz, int tamanio)
        {
            Console.Clear(); //Se limpia la pantalla cada vez que se llama al método
            Console.WriteLine("Ahora debes llenar la matriz, solo se permiten valores entre 1 y 100");
            try
            {
                for (int renglon = 0; renglon < tamanio; renglon++) //Se itera cada renglón 
                {
                    for (int columna = 0; columna < tamanio; columna++) //Se itera cada columna
                    {
                        Console.Write("Ingrese el valor de [{0}][{1}]: ", columna, renglon);
                        int valor = Convert.ToInt32(Console.ReadLine());
                        if (valor >= -100 && valor <= 100) //Se verifica que el valor ingresado no sea mayor ni menor de ese rango
                        {
                            matriz[columna, renglon] = valor; //Asigna el valor ingresado a la posición de la iteración actual
                        }
                        else
                        {
                            throw new ValorException("Solo se permiten valores  entre 1 y 100");
                        }
                    }
                }
                return matriz;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingrese sólo un número entero");
                Console.ReadKey();
                return GeneraMatriz(matriz, tamanio);
            }
            catch (ValorException ve)
            {
                Console.WriteLine(ve.Message);
                Console.ReadKey();
                return GeneraMatriz(matriz, tamanio);
            }
        }
    }
}