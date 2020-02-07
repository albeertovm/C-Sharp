using System;

namespace tarea2.cs
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese la cantidad de alumnos a calificar: ");
            int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());
            Alumno [] alumnos = new Alumno[cantidadAlumnos];
            int contador = 0;
            while (contador < cantidadAlumnos) {
                Console.WriteLine("Ingrese el nombre del alumno {0}", contador);
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido paterno del alumno {0}", contador);
                string apaterno = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido materno {0}", contador);
                string amaterno = Console.ReadLine();
                Console.WriteLine("Ingrese la calificación del proyecto del alumno {0}", contador);
                int proyecto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número de tareas entregadas por el alumno {0}", contador);
                int tareas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número de participaciones del alumno {0}", contador);
                int participaciones = Convert.ToInt32(Console.ReadLine());
                alumnos[contador] = new Alumno(nombre,apaterno,amaterno,proyecto,tareas,participaciones);
                contador++;
            }
            foreach (Alumno objeto in alumnos)
            {
                Console.WriteLine("El alumno {0} {1} {2} tiene {3}", objeto.Nombre, objeto.APaterno, objeto.AMaterno, (Calculadora.Calificar(objeto.Proyecto, objeto.Tareas, objeto.Participaciones)));
            }
        }
    }
}