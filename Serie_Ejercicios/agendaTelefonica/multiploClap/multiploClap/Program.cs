using System;

namespace multiploClap
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Clear(); //Limpia la pantalla en cada llamada al método
                Console.WriteLine("Este programa calculará en los números del 1 al 100 si dos números que ingreses son múltiplos de alguno");
                Console.WriteLine("o simplemente aparecen en alguno escribiendo clap si se cumple alguna condición");
                Console.WriteLine();
                Console.Write("Ingresa el primer número: ");
                //FormatException, RangeException
                int num1 = 0, num2 = 0;
                int numR1 = Convert.ToInt32(Console.ReadLine());
                if ((numR1 > 0) && (numR1 < 10)) //Verifica que el número ingresado se encuentre en el rango 1-9
                {
                    num1 = numR1;
                    Console.Write("Ingresa el segundo número: ");
                    //FormatException, RangeException
                    int numR2 = Convert.ToInt32(Console.ReadLine());
                    if ((numR2 > 0) && (numR2 < 10)) //Verifica que el número ingresado se encuentre en el rango 1-9
                    {
                        num2 = numR2;
                        CalculaMultiplo(num1, num2);
                    }
                    else
                    {
                        throw new RangeException("Ingresa un número entre el 1 y 9");
                    }
                }
                else
                {
                    throw new RangeException("Ingresa un número entre el 1 y 9");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa un número");
                Console.WriteLine("Ingrese (Esc) para salir o cualquier otra tecla para volver a ejecutar el programa");
                if (Console.ReadKey().Key == ConsoleKey.Escape) //Si se ingresa la tecla Esc se termina la ejecución del programa, de lo contario continua 
                {
                    Environment.Exit(0); //Termina la ejecución del programa
                }
                else
                {
                    Main();
                }
            }
            catch (RangeException re)
            {
                Console.WriteLine(re.Message);
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
        public static void CalculaMultiplo(int num1, int num2) {
            int contador = 0;
            while (contador++ < 100)
            {
                if ((contador % num1) == 0 || (contador % num2) == 0) //Verifica que num sea múltiplo de contador
                {
                    Console.WriteLine("Clap");
                }
                else if ((contador % 10) == num1 || (contador % 10) == num2) //Verifica que num se encuentre como unidad en contador ejemplo si num es 5 se escribirá clap en 55 o 35 o 25
                {
                    Console.WriteLine("Clap");
                }
                else if ((contador - num1 * 10) < 10 && (contador - num1 * 10) > 0 || (contador - num2 * 10) < 10 && (contador - num2 * 10) > 0) //Verifica que num se encuentre como décima en contador ejemplo si num es 4 se escribirá clap en 41 o 42 o 47
                {
                    Console.WriteLine("Clap");
                }
                else
                {
                    Console.WriteLine(contador);
                }
            }
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
}
