using System;
using System.Collections.Generic;
using System.Text;

namespace becarioMart
{
    class Pago
    {
        public static void MostrarProductos(int no_producto, List<string> productos, List<double> precios) 
        {
            Console.Clear();
            Console.WriteLine("Lista de compra:");
            double total = 0.00;
            double dinero = 500.00; //Dinero que tiene el becario para gastar en becarioMart
            for (int contador = 0; contador < no_producto; contador++) 
            {
                Console.WriteLine("Producto: {0} Precio: {1:C}", productos[contador], precios[contador]);
                total += precios[contador]; //Realiza la suma de los precios
            }
            Console.WriteLine("Productos: {0} Total: {1:C}\n", no_producto, total); //Se imprime el total en formato dinero
            try
            {
                Console.Write("(C)omprar / (D)ejar productos: ");
                char opcion = Convert.ToChar(Console.ReadLine());
                switch (char.ToUpper(opcion))
                {
                    case 'C':
                        if (total > dinero)  //Verifica si la compra es mayor al dinero que tiene el becario
                        {
                            Dejar.DejarProducto(no_producto, productos, precios, total, dinero);
                        }
                        else if (no_producto == 1 && total < dinero)
                        {
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    case 'D':
                        Dejar.DejarProducto(no_producto, productos, precios, total, dinero);
                        break;
                    default:
                        throw new SwitchException("Ingresa una opción válida");
                }
            }
            catch (SwitchException se)
            {
                Console.WriteLine(se.Message);
                Console.ReadKey();
                MostrarProductos(no_producto, productos, precios);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa una opción válida");
                Console.ReadKey();
                MostrarProductos(no_producto, productos, precios);
            }
        }
    }
}
