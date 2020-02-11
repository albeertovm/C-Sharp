using System;

namespace persona
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Clear(); //Limpia la pantalla cada quez que se llama el método
                Console.WriteLine("Este programa te pedirá que ingreses tus datos >:D");
                Console.Write("Ingresa tu nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingresa tu edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                if(edad > 11 && edad < 100) //Valida que la edad ingresada sea entre 12 y 100 años
                {
                    Console.Write("Ingresa tu estatura: ");
                    double estatura = Convert.ToDouble(Console.ReadLine());
                    if (estatura > 0.5 && estatura < 2.5) //Valida que la estatura ingresada sea entre 0.5mts y2.5mts
                    {
                        Console.Write("Ingresa tu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());
                        if (peso > 30.00 && peso < 200.00) //Valida que el peso ingresado esté entre los 30kgs y 200kgs
                        {
                            Persona p1 = new Persona(nombre, edad, estatura, peso);
                            p1.MostrarDatos();
                            p1.Saludar();
                            p1.Aprobar();
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
                        else 
                        {
                            throw new NumerosException("Ingresa un peso real"); //Excepcion de datos reales
                        }
                    }
                    else
                    {
                        throw new NumerosException("Ingresa una altura real");
                    }
                }
                else
                {
                    throw new NumerosException("Ingresa una edad válida");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa los datos correctamente");
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
            catch (NumerosException ne)
            {
                Console.WriteLine(ne.Message);
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
        }
    }
}
