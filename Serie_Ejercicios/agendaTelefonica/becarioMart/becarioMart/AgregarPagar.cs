using System;
using System.Collections.Generic;
using System.Text;

namespace becarioMart
{
    class AgregarPagar
    {
        public static void Menu(int no_producto, List<string> productos, List<double> precios)
        {
            try 
            {
                Console.Clear();
                Console.Write("¿(A)gregar más o productos a la lista / (C)arrito de compras: ");
                char opcion = Convert.ToChar(Console.ReadLine());
                switch (char.ToUpper(opcion))
                {
                    case 'A':
                        no_producto++;
                        Program.IngresaProductos(no_producto, productos, precios);
                        break;
                    case 'C':
                        no_producto++;
                        //Como el no_producto empieza en 1, se debe restar ese 1 para que se ajuste al índice de las listas
                        Pago.MostrarProductos(no_producto - 1 , productos, precios); //Llama al método que se encargará de mostrar los productos y de realizar el pago
                        break;
                    default:
                        throw new SwitchException("Ingresa una opción válida");
                }
            }
            catch (SwitchException se)
            {
                Console.WriteLine(se.Message);
                Console.ReadKey();
                Menu(no_producto, productos, precios);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa una opción válida");
                Console.ReadKey();
                Menu(no_producto, productos, precios);
            }
        }
    }
}
