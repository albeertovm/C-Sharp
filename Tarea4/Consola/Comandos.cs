using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Consola
{
    class Comandos
    {
        public static void MuestraDirectorio(string path, List<string> historial)
        {
            string directorioActual = Directory.GetCurrentDirectory();  /*Se vuelve a realizar el set del directorio actual, esto se hace debido a los errores que puedan
                                                                        ocurrir dentro de la ejecución*/
            try
            {
                DirectoryInfo directorio = new DirectoryInfo(path);     //Se obtienen los elementos contenidos en el directorio especificado
                if (directorio.Exists)          //Verifica que el directorio especificado exista
                {
                    Console.WriteLine("\nCarpetas:\n");
                    foreach (var carpeta in directorio.GetDirectories()) //Obtiene los directorios del path
                    {
                        Console.WriteLine(carpeta.Name);            //Se listan las carpetas contenidas en el directorio
                    }
                    Console.WriteLine("\nArchivos:\n");
                    foreach (var archivo in directorio.GetFiles()) //Obtiene los archivos del path
                    {
                        Console.WriteLine(archivo.Name);            //Se listan los archivos contenidas en el directorio
                    }
                    ValidacionesComandos.ValidaComandos(directorioActual, historial);
                }
                else
                {
                    throw new DirectoryNotFoundException();
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("No se encontró el directorio especificado");
                ValidacionesComandos.ValidaComandos(directorioActual, historial);              /*En caso de que exista un error porque no se escrició bien el directorio o no se encontró,
                                                                                               se vuelve a ejecutar el método con un argumento correcto (el directorio actual)*/
            }
        }
        public static void CambiaDirectorio(string nuevoDirectorio, string directorioActual, List<string> historial)
        {
            try
            {
                Directory.SetCurrentDirectory(nuevoDirectorio);         /*Se establece el nuevo directorial actual
                                                                        el programa contempla espacios como nombres de carpetas y archivos
                                                                        además de contemplar las diferentes unidades de almacenamiento*/
                string nuevo = Directory.GetCurrentDirectory();         /*Se vuelve a realizar el set del directorio actual, esto se hace debido a los errores que puedan ocurrir
                                                                        y para obtener la ruta absoluta del del*/
                ValidacionesComandos.ValidaComandos(nuevo, historial);
            }
            catch (IOException) 
            {
                Console.WriteLine("Verifique el directorio ingresado");
                ValidacionesComandos.ValidaComandos(directorioActual, historial);
            }
        }

        public static void CreaArchivo(string archivo, List<string> historial) //Recibe como parámetros el archivo a crear o directorio donde se creará el archivo (archivo) y el historial
        {
            string directorioActual = Directory.GetCurrentDirectory();  /*El progrma contempla espacios como nombres de carpetas y archivos
                                                                        además de contemplar las diferentes unidades de almacenamiento*/
            try
            {
                if (File.Exists(archivo))       //Verifica que el archivo exista, de ser así notifica al usuario que ya existe
                {
                    Console.WriteLine("El archivo ya existe");
                }
                else
                {
                    File.CreateText(archivo).Close();   //De lo contrario crea el archivo y lo cierra para que no lo ocupe el proceso de la consola
                    Console.WriteLine("Archivo creado");
                }
                ValidacionesComandos.ValidaComandos(directorioActual, historial);
            }
            catch (IOException)         //Recibe todos los errores que puedan ocurrir
            {
                Console.WriteLine("Verifica el directorio ingresado");
                ValidacionesComandos.ValidaComandos(directorioActual, historial);
            }

        }

        public static void MueveArchivo(string directorios, List<string> historial)
        {
            string directorioActual = Directory.GetCurrentDirectory();
            try
            {
                string[] argumentos = directorios.Split(" -> ", 2, StringSplitOptions.RemoveEmptyEntries); /*Se debe especificar "->" para indicar el directorio destino
                                                                                                            el programa contempla espacios como nombres de carpetas y archivos
                                                                                                            además de contemplar las diferentes unidades de almacenamiento*/
                if (File.Exists(argumentos[0]) && argumentos.Length > 1)                /*En caso de que no se ingrese directorio destino, solo el nombre del archivo en el 
                                                                                        argumento 2, se mueve el archivo al directorio actual con el nombre
                                                                                        especificado como argumento 2*/
                {
                        File.Move(argumentos[0], argumentos[1]);        //Mueve el archivo al path especificado
                        Console.WriteLine("Se ha movido el arhivo");
                        ValidacionesComandos.ValidaComandos(directorioActual, historial);
                }
                else if (argumentos.Length == 1)
                {
                    throw new FormatMoveException();
                }
                else
                {
                    throw new IOException();
                }
            }
            catch (FormatMoveException fe) //En caso de que no se ingrese ->
            {
                Console.WriteLine(fe.Message);
                ValidacionesComandos.ValidaComandos(directorioActual, historial);
            }
            catch (IOException)
            {
                Console.WriteLine("Verifique el directorio ingresado, recuerda poner la ruta absoluta");
                ValidacionesComandos.ValidaComandos(directorioActual, historial);
            }
        }
        public static void MuestraHistorial(List<string> historial) 
        {
            foreach (string comando in historial)           //Lee los elementos de la lista historial
            {
                Console.WriteLine(comando);                 //Imprime los "comandos" ingresados
            }
            string directorioActual = Directory.GetCurrentDirectory();
            ValidacionesComandos.ValidaComandos(directorioActual, historial);
        }
        public static void LimpiaPantalla(List<string> historial)
        {
            Console.Clear();            //Limpia la pantalla
            string directorioActual = Directory.GetCurrentDirectory();
            ValidacionesComandos.ValidaComandos(directorioActual, historial);
        }
        public static void TerminarPrograma() 
        {
            Environment.Exit(0);    //Termina la ejecución del programa
        }
    }
}
