using System;
using System.Collections.Generic;
using System.Text;

namespace tarea2.cs
{
    public class Alumno
    {
        public string Nombre { set; get; }
        public string APaterno { set; get; }
        public string AMaterno { set; get; }
        public int Proyecto { get; }
        public int Tareas { get; }
        public int Participaciones { get; }
        public Alumno() { }
        public Alumno(string nombre, string apaterno, string amaterno, int proyecto, int tareas, int participaciones)
        {
            Nombre = nombre;
            APaterno = apaterno;
            AMaterno = amaterno;
            Proyecto = proyecto;
            Tareas = tareas;
            Participaciones = participaciones;
        }
    }
    public static class Calculadora
    {
        public static double Calificar(int proyecto, int tareas, int participaciones)
        {
            double calificacion=0;
            if (proyecto >= 0 && proyecto <= 10)
            {
                calificacion += (proyecto * 60) / 10;
                if (tareas >= 0 && tareas <= 5)
                {
                    calificacion += (tareas * 40) / 5;
                    if (participaciones >= 0 && participaciones > 5)
                    {
                        calificacion += (calificacion * .08);
                        if (calificacion < 50)
                            return (50 / 10);
                        else if (calificacion > 100)
                            return (100 / 10);
                        else if (calificacion >= 50 && calificacion <= 100)
                            return (calificacion / 10);
                        else return 0;
                    }
                    else if (participaciones >= 0 && participaciones < 6)
                    {
                        if (calificacion < 50)
                            return (50 / 10);
                        else if (calificacion > 100)
                            return (100 / 10);
                        else if (calificacion >= 50 && calificacion <= 100)
                            return (calificacion / 10);
                        else return 0;
                    }
                    else return 0;
                }
                else return 0;
            }
            else return 0;
        }
    }
}