using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    class InputException : Exception
    {
        public InputException() : base("Verifique el comando ingresado") { } //Envía el mensaje de error si no se ingresa algún comando correctamente
    }
    class ChangeDirectoryException : Exception
    {
        public ChangeDirectoryException() : base("El comando recibe como argumento un directorio o el directorio padre (..)") { } //Envía el mensaje de error si no se ingresa algún comando correctamente
    }
    class FileMissingException : Exception
    {
        public FileMissingException() : base("El comando recibe como argumento el archivo a crear") { } //Envía el mensaje de error si no se ingresa algún comando correctamente
    }
    class FormatMoveException : Exception
    {
        public FormatMoveException() : base("Recuerda poner un -> para especificar el directorio destino") { } //Envía el mensaje de error si no se ingresa algún comando correctamente
    }
    class ParametrosExceptions : Exception
    {
        public ParametrosExceptions() : base("El comando recibe 2 argumentos PathOrigen -> PathDestino") { } //Envía el mensaje de error si no se ingresa algún comando correctamente
    }
}
