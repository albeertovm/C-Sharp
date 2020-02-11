using System;

namespace fibonacci
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Este programa calculará la sucesión fibonacci hasta el número que le indiques");
                Console.Write("Igresa la cantidad de números fibonacci a calcular: ");
                //FormatException, PositivoMayorZeroException
                ulong numR = Convert.ToUInt64(Console.ReadLine()); //Se concierte a ulong para poder realizar el cálculo de más números fibonacci
                if (numR > 0) {
                    ulong actual = 0, siguiente = 1, num = numR, contador = 1;
                    fibonacci(num, actual, siguiente, contador);    /*Realiza la suceción fibonacci de manera recursiva, se envía el argumento numero ingresado -1 
                                                                    para controlar las iteraciones, el número actual de la sucesión (se inicia con 0), el número siguiente 
                                                                    a la suceción (el número 1) y un contador para imprimir el orden de los números impresos.*/
                }
                else
                {
                    throw new PositivoMayorZeroException("Ingresa un número positivo mayor a cero"); //Verifica que se ingresen números mayores a cero
                }
            }
            catch (FormatException fe) 
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa un número");
            }
            catch (PositivoMayorZeroException pmze) 
            {
                Console.WriteLine(pmze.Message);
            }
            Console.ReadKey();
        }
        public static void fibonacci(ulong num, ulong actual, ulong siguiente, ulong contador) {
            Console.WriteLine("{0}: {1}", contador, actual);
            if (num == 1) //Cuando n-1 llega a cero se termina la ejecución del programa
            {
                Console.WriteLine("Ejecución terminada");
            }
            else
            {
                fibonacci(num - 1, siguiente, siguiente += actual, ++contador); /*En la primera iteración se imprime el valor actual 0 y el siguiente 1 y num es igual a n, se pasan otra vez los
                                                                                argumentos descritos, en la siguiente iteración se imprime el valor actual 1 y siguiente 1 ya que en la iteración 
                                                                                anterior actual pasó a ser 1 y siguiente quedó como 0+1 y num es igual a n-1, en la tercera iteración actual es igual 
                                                                                a 1 ya que siguiente valía 1 y el valor siguiente pasa a ser 1+1, así continua hasta que num sea igual a 1*/
            }
        }
    }
}