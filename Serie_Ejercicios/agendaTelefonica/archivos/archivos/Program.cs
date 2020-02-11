using System;
using System.IO;

namespace archivos
{
    class Program
    {
        static void Main()
        {
            try
            {
                //Este programa imprimirá los números del 1 al 10 en un archivo
                //Si el archivo ya existe, se escribirá que ya existe
                int numero = 1;
                string path = Directory.GetCurrentDirectory(); //Obtiene el directorio actual
                if (!File.Exists(path + "\\Prueba.txt")) //Verifica si existe el archivo
                {
                    using (StreamWriter sw = File.CreateText(path + "\\Prueba.txt")) //Crea el archivo
                    {
                        while (numero < 11)
                        {
                            sw.WriteLine(numero);
                            numero++;
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path + "\\Prueba.txt")) //Anexa al contenido del archivo el texto indicado
                    {
                        sw.WriteLine("El archivo ya existe");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Algo salió mal");
            }
        }
    }
}