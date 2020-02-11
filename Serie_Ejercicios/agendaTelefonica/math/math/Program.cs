using System;

namespace math
{
    class Program
    {
        static void Main()
        {
            Circulo c1 = new Circulo() { Radio = Math.Abs(-5) };
            double area = c1.CalcularArea(c1.Radio);
            Console.WriteLine("Datos del círculo: ");
            Console.WriteLine("Radio: {0} Área: {1}", c1.Radio, area);
            //Math.abs devuelve el valor absoluto de un número 
            Triángulo t1 = new Triángulo() { Base = 5, Altura = Math.Abs(-10) };
            double t_area = t1.CalculaArea(t1.Base,t1.Altura);
            Console.WriteLine("Datos del triángulo: ");
            Console.WriteLine("Base: {0} Altura: {1} Área: {2}", t1.Base, t1.Altura, t_area);
        }
    }
}

/*
Campos:

    PI      Math.PI             Valor del numero  π
    E       Math.E              Valor de la constante de Euler e

Métodos:

    abs      Math.abs(x)        Valor absoluto de x
    ceil     Math.ceil(x)       Menor numero  entero mayor que x
    floor    Math.floor(x)      Mayor numero  entero menor que x
    round    Math.round(x)      Numero  entero redondeando x
    max      Math.max(x,y)      Maximo entre x e y
    min      Math.min(x,y)      Mınimo entre x e y
    pow      Math.pow(x,y)      Valor de x elevado a y
    sqrt     Math.sqrt(x)       Raız cuadrada de x
    random   Math.random()      Numero  aleatorio entre 0 y 1
    cos      Math.cos(x)        Coseno de x (en radianes)
    sin      Math.sin(x)        Seno de x (en radianes)
    tan      Math.tan(x)        Tangente de x (en radianes)
    acos     Math.acos(x)       Arco Coseno de x (en radianes)
    asin     Math.asin(x)       Arco Seno de x (en radianes)
    atan     Math.atan(x)       Arco Tangente de x (en radianes)
    exp      Math.exp(x)        Valor de e elevado a x
    log      Math.log(x)        Logaritmo neperiano de x
*/
