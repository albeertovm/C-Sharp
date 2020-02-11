using System;
using System.Collections.Generic;
using System.Text;

namespace becarioMart
{
    class Dejar
    {
        public static void DejarProducto(int no_producto, List<string> productos, List<double> precios, double total, double dinero)
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Lista de compra:");
                    for (int contador = 0; contador < no_producto; contador++)
                    {
                        Console.WriteLine("Índice: {0} Producto: {1} Precio: {2:C}", contador, productos[contador], precios[contador]); //Se imprime el índice, por eso se realiza nuevamente este método
                    }
                    Console.WriteLine("productos: {0} Total: {1:C}\n", no_producto, total); //Se imprime el total en formato dinero
                    Console.WriteLine("En caso de que su total sea mayor a $500.00 tendrá que dejar productos hasta que se adapte al presupuesto");
                    Console.Write("Ingrese el índice del producto a dejar: ");
                    int indice = Convert.ToInt32(Console.ReadLine());
                    for (int contador = 0; contador < no_producto; contador++)
                    {
                        if (contador == indice)
                        {
                            Console.WriteLine("Índice: {0} Producto: {1} Precio: {2:C} se ha dejado", contador, productos[contador], precios[contador]); //Se elimina el índice que se ingresó
                            total -= precios[contador]; //Realiza la resta del precio de los productos dejados
                            productos.RemoveAt(contador); //Se elimina el producto por su indice
                            precios.RemoveAt(contador);
                            no_producto--; //Se disminuye el número de productos 
                            Console.ReadKey();
                        }
                        else
                        {
                            throw new SwitchException("Ingresa una opción válida");
                        }
                    }
                }
                while (total > dinero);
                Console.ReadKey();
                Pago.MostrarProductos(no_producto, productos, precios);
            }
            catch (SwitchException se)
            {
                Console.WriteLine(se.Message);
                Console.ReadKey();
                DejarProducto(no_producto, productos, precios, total, dinero);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa una opción válida");
                Console.ReadKey();
                DejarProducto(no_producto, productos, precios, total, dinero);
            }
        }
    }
}
