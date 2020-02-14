using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Consola
{
    class ValidacionesComandos : Program 
    {
        public static void ValidaComandos(string directorioActual, List<string> historial)
        {
            try
            {
                Console.Write("{0}> ", directorioActual);           //Se imprime el prompt 
                string comando = Console.ReadLine();                //Se solicita una cadena para ser interpretada como "comando" con su respectivo "argumento"
                string[] argumentos = comando.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries); /*Separa las palabras ingresadas cuando encuentra un espacio,
                                                                                                    solamente obtiene 2 subcadenas el "comando" y su "argumento"
                                                                                                    si existen espacios vacíos se eliminan
                                                                                                    el programa contempla espacios como nombres de carpetas y archivos
                                                                                                    además de contemplar las diferentes unidades de almacenamiento*/
                historial.Add(comando);                                    //Lo que sea que se ingrese se guardará como historial
                if (argumentos[0] == "dir" && argumentos.Length == 1)       //Comando dir, verifica que solamente se haya ingresado la cadena dir
                {
                    Comandos.MuestraDirectorio(directorioActual, historial);
                }
                else if (argumentos[0] == "dir")                            /*En caso de que se haya ingresado la cadena dir y más texto, 
                                                                            la segunda cadena se toma como argumento de directorio*/
                {
                    Comandos.MuestraDirectorio(argumentos[1], historial);            //Se envía como argumento la segunda subcadena
                }
                else if (argumentos[0] == "cd" && argumentos.Length == 1)   //Se verifica si solo se ingreso el comando sin argumentos
                {
                    throw new ChangeDirectoryException();
                }
                else if (argumentos[0] == "cd" && argumentos[1] == "..")        //verifica que sólo se ingrese "cd .." para cambiar al directorio padre
                {
                    string directorioPadre = Directory.GetParent(directorioActual).FullName;    //Obtiene el directorio padre
                    Comandos.CambiaDirectorio(directorioPadre , directorioActual, historial);
                }
                else if (argumentos[0] == "cd")
                {
                    Comandos.CambiaDirectorio(argumentos[1], directorioActual, historial);
                }
                else if (argumentos[0] == "touch" && argumentos.Length == 1) //Se verifica si solo se ingreso el comando sin argumentos
                {
                    throw new FileMissingException();
                }
                else if (argumentos[0] == "touch")
                {
                    Comandos.CreaArchivo(argumentos[1], historial);
                }
                else if (argumentos[0] == "move" && argumentos.Length == 1) //Se verifica si solo se ingreso el comando sin argumentos
                {
                    throw new ParametrosExceptions();
                }
                else if (argumentos[0] == "move") 
                {
                    Comandos.MueveArchivo(argumentos[1], historial);
                }
                else if (argumentos[0] == "history" && argumentos.Length == 1)//Se verifica si solo se ingreso el comando sin argumentos
                {
                    Comandos.MuestraHistorial(historial);
                }
                else if (argumentos[0] == "cls" && argumentos.Length == 1)//Se verifica si solo se ingreso el comando sin argumentos
                {
                    Comandos.LimpiaPantalla(historial);
                }
                else if (argumentos[0] == "exit" && argumentos.Length == 1)//Se verifica si solo se ingreso el comando sin argumentos
                {
                    Comandos.TerminarPrograma();
                }
                else
                {
                    throw new InputException();     //Si no se ingresa algún comando establecido se origina esta excepción
                }
            }
            catch (InputException ie)
            {
                Console.WriteLine(ie.Message);
                ValidaComandos(directorioActual, historial);
            }
            catch (IndexOutOfRangeException)    /*Se origina porque se comparan los índices de un arreglo en los if,
                                                si no se ingresa al menos un caracter el índice 1 provoca esta excepción*/
            {
                ValidaComandos(directorioActual, historial);              /*Como el error solo es causado en caso de que no se ingrese nada (Enter o Space)
                                                                          solo se vuelve a llamar a la función para que muestre nuvamente el prompt*/
            }
            catch (ChangeDirectoryException cde)    //Se origina porque se ingresa el comando cd sin ninún argumento
            {
                Console.WriteLine(cde.Message);
                ValidaComandos(directorioActual, historial);
            }
            catch (FileMissingException fme)
            {
                Console.WriteLine(fme.Message);
                ValidaComandos(directorioActual, historial);
            }
            catch (ParametrosExceptions pe)
            {
                Console.WriteLine(pe.Message);
                ValidaComandos(directorioActual, historial);
            }
        }
    }
}
