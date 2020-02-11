using System;

namespace calculadoraNormal
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Este programa es una calculadora de dos números");
                Console.Write("Ingresa el primer número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                if (numero1 >= -9999999999.9 && numero1 <= 9999999999.9)
                {
                    Console.Write("Ingresa el segundo número: ");
                    double numero2 = Convert.ToDouble(Console.ReadLine());
                    if (numero2 >= -9999999999.9 && numero2 <= 9999999999.9)
                    {
                        Menu.MuestraMenu(numero1, numero2);
                    }
                    else
                    {
                        throw new RangoException("Solo se permiten números entre el -9,999,999,999.9 y 9,999,999,999.9");
                    }
                }
                else
                {
                    throw new RangoException("Solo se permiten números entre el -9,999,999,999.9 y 9,999,999,999.9");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingrese un número");
                Console.ReadKey();
                Main();
            }
            catch (RangoException re)
            {
                Console.WriteLine(re.Message);
                Console.ReadKey();
                Main();
            }
        }
    }
}
