using System;
using System.Collections.Generic;

namespace agendaTelefonica
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Este programa simula una agenda telefónica, selecciona una opción:\n");
            Dictionary<string, string> contactos = new Dictionary<string, string>(); //Se crea un diccionario para almacenar a los contactos
            MuestraMenu(contactos); //Se envía el diccionario creado como argumento para que cada vez que se llame a la función sea el mismo diccionario el que se manipule
        }
        public static void MuestraMenu(Dictionary<string, string> contactos) {
            Console.Clear();
            Console.WriteLine("\n(A)gregar contacto");
            Console.WriteLine("(E)liminar contacto");
            Console.WriteLine("(M)ostrar contacto");
            Console.WriteLine("(S)alir");
            Console.Write("\nIngrese una opción: ");
            try
            {
                //FormatException
                char opcion = Convert.ToChar(Console.ReadLine());
                //SwitchException -> que no se ingrese alguna de las opciones especificadas
                switch (char.ToUpper(opcion)) //Si se ingresa una opción válida, se le hace un cast a upper
                {
                    case 'A':
                        Console.Clear();
                        Console.Write("Ingrese el nombre del contacto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el teléfono del contacto: ");
                        string telefono = Console.ReadLine();
                        //ArgumentException -> En caso de que se ingrese una llave (nombre de contacto) ya registrado
                        contactos.Add(nombre, telefono); //Se agrega la llave y su valor al diccionario contactos
                        Console.WriteLine("El contacto {0} ha sido agregado", nombre);
                        Console.ReadKey();
                        MuestraMenu(contactos);
                        break;
                    case 'E':
                        Console.Clear();
                        Console.Write("Ingrese el contacto a eliminar: ");
                        string eliminar = Console.ReadLine();
                        if (contactos.ContainsKey(eliminar)) //Se verifica que la llave (nombre del contacto) se encuentre en el diccionario contactos
                        {
                            Console.WriteLine("¿Está seguro de que desea eliminar este contacto? (S/N):");
                            Console.WriteLine("Contacto: " + eliminar + " Teléfono: " + contactos[eliminar]);
                            char confirmacion = Convert.ToChar(Console.ReadLine());
                            switch (char.ToUpper(confirmacion)) //Se solicita confirmación para el borrado del elemento
                            {
                                case 'S':
                                    contactos.Remove(eliminar);
                                    Console.WriteLine("El contacto {0} ha sido eliminado", eliminar);
                                    Console.ReadKey();
                                    MuestraMenu(contactos);
                                    break;
                                case 'N':
                                    Console.WriteLine("Eliminación cancelada");
                                    Console.ReadKey();
                                    MuestraMenu(contactos);
                                    break;
                                default:
                                    throw new SwitchException("Ingrese una opción válida");
                            }
                        }
                        else
                        {
                            throw new NoResultadosException("No se encontraron resultados coincidentes a la búsqueda");
                        }
                        MuestraMenu(contactos);
                        break;
                    case 'M': //Dos variantes una donde se muestran todos los contactos y otra donde se muestra un solo contacto
                        Console.Clear();
                        Console.WriteLine("(T)odos los contactos");
                        Console.WriteLine("(U)n contacto");
                        Console.WriteLine("Ingrese una opción: ");
                        char cOpcion = Convert.ToChar(Console.ReadLine());
                        switch (char.ToUpper(cOpcion))
                        {
                            case 'T':
                                Console.Clear();
                                Console.WriteLine("Contactos: ");
                                foreach (KeyValuePair<string, string> elemento in contactos)
                                {
                                    Console.WriteLine("Contacto: " + elemento.Key + " Teléfono: " + elemento.Value);
                                }
                                Console.ReadKey();
                                MuestraMenu(contactos);
                                break;
                            case 'U':
                                Console.Clear();
                                Console.Write("Ingrese el contacto a buscar: ");
                                string buscar = Console.ReadLine();
                                if (contactos.ContainsKey(buscar)) //Se verifica que la llave (nombre del contacto) se encuentre en el diccionario contactos
                                {
                                    Console.WriteLine("Contacto: " + buscar + " Teléfono: " + contactos[buscar]); //Se imprime el contacto y su teléfono
                                    Console.ReadKey();
                                }
                                else
                                {
                                    throw new NoResultadosException("No se encontraron resultados coincidentes a la búsqueda");
                                }
                                Console.ReadKey();
                                MuestraMenu(contactos);
                                break;
                            default:
                                throw new SwitchException("Ingrese una opción válida");
                        }
                        MuestraMenu(contactos);
                        break;
                    case 'S':
                        Console.Clear();
                        Console.WriteLine("Ejecución terminada");
                        Environment.Exit(0);
                        break;
                    default:
                        throw new SwitchException("Ingrese una opción válida");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingrese un caracter válido");
                MuestraMenu(contactos);
            }
            catch (SwitchException se)
            {
                Console.WriteLine(se.Message);
                MuestraMenu(contactos);
            }
            catch (NoResultadosException nre) {
                Console.WriteLine(nre.Message);
                MuestraMenu(contactos);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Console.WriteLine("Ya existe un registro con ese nombre");
                MuestraMenu(contactos);
            }
        }
    }
}
