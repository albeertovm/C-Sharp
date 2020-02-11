using System;
using System.Collections.Generic;

namespace becarioMart
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al becarioMart");
            Console.WriteLine("Presiona cualquier tecla para empezar a comprar");
            int no_producto = 1;
            List<string> productos = new List<string>(); //Se crean listas vacías
            List<double> precios = new List<double>();
            Console.ReadKey();
            IngresaProductos(no_producto, productos, precios);
        }
        public static void IngresaProductos(int no_producto, List<string> productos, List<double> precios) //Recibe el número de productos que se han ingresado, la lista de productos y su lista de precios
        {
            try
            {
                Console.Clear();
                Console.Write("Ingresa el nombre del producto {0}: ", no_producto);
                string producto = Console.ReadLine();
                Console.Write("Ingresa el precio del producto {0}: ", no_producto);
                double precio = Convert.ToDouble(Console.ReadLine()); //FormatException
                if (precio > 0 && precio < 1000.00) //Precio máx $1000.00, precio mínimo $1.00
                {
                    productos.Add(producto); //Si pasa las validaciones se agrega el producto y su precio a sus respectivas listas
                    precios.Add(precio);
                    AgregarPagar.Menu(no_producto, productos, precios);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa un precio válido");
                Console.ReadKey();
                IngresaProductos(no_producto, productos, precios);
            }
        }
    }
}
