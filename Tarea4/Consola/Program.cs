using System;
using System.IO;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        public static void Main()       //Solamente se utiliza para iniciar el programa y realizar el set de los valores inciales
        {
            try
            {
                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));     //Se establece el directorial actual "Mis documentos"
                string directorioActual = Directory.GetCurrentDirectory();                                           //Obtiene el directorio actual
                List<string> historial = new List<string>();                                          //Se crea una lista para guardar las cadenas (comandos) ingresados
                ValidacionesComandos.ValidaComandos(directorioActual, historial);                     //Envía como argumento el directorio actual
            }
            catch (DirectoryNotFoundException) 
            {
                Console.WriteLine("No se encontró el directorio \"Mis documentos\""); //En caso de que no se ecncuentré el directorio "Mis documentos" se detiene la ejecuión
                Environment.Exit(0);
            }
        }
    }
}
