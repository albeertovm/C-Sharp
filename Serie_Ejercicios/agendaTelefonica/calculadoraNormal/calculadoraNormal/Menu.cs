using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraNormal
{
    class Menu
    {
        public static  void MuestraMenu(double numero1, double numero2) {
            try
            {
                double operacion = 0;
                Console.Clear();
                Console.WriteLine("Menú:\n");
                Console.WriteLine("(S)uma");
                Console.WriteLine("(R)esta");
                Console.WriteLine("(M)ultiplicación");
                Console.WriteLine("(D)ivisión");
                Console.WriteLine("(I)ngresar dos nuevos números");
                Console.WriteLine("(E)Salir");
                Console.Write("\nSelecciona una opción: ");
                char opcion = Convert.ToChar(Console.ReadLine());
                switch (char.ToUpper(opcion))
                {
                    case 'S':
                        operacion = numero1 + numero2;
                        Console.WriteLine("{0} + {1} = {2}", numero1, numero2, operacion);
                        Console.ReadKey();
                        MuestraMenu(numero1, numero2);
                        break;
                    case 'R':
                        operacion = numero1 - numero2;
                        Console.WriteLine("{0} - {1} = {2}", numero1, numero2, operacion);
                        Console.ReadKey();
                        MuestraMenu(numero1, numero2);
                        break;
                    case 'M':
                        operacion = numero1 * numero2;
                        Console.WriteLine("{0} * {1} = {2}", numero1, numero2, operacion);
                        Console.ReadKey();
                        MuestraMenu(numero1, numero2);
                        break;
                    case 'D':
                        if (numero2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else
                        {
                            operacion = numero1 / numero2;
                            Console.WriteLine("{0} / {1} = {2}", numero1, numero2, operacion);
                            Console.ReadKey();
                            MuestraMenu(numero1, numero2);
                        }
                        break;
                    case 'I':
                        Program.Main();
                        break;
                    case 'E':
                        Console.WriteLine("Hasta luego");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        throw new SwitchException("Ingresa una opción válida");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa una opción válida");
                Console.ReadKey();
                MuestraMenu(numero1, numero2);
            }
            catch (SwitchException se)
            {
                Console.WriteLine(se.Message);
                Console.ReadKey();
                MuestraMenu(numero1, numero2);
            }
            catch (DivideByZeroException dvze)
            {
                Console.WriteLine(dvze.Message);
                Console.WriteLine("No se puede dividir entre cero");
                Console.ReadKey();
                MuestraMenu(numero1, numero2);
            }
        }
    }
}
