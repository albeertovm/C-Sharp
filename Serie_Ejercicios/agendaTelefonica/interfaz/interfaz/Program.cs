using System;

namespace interfaz
{
    class Program
    {
        //El objetivo de la interfaz de implementar de manera obligatoria los métodos indicados
        static void Main()
        {
            Console.WriteLine("Halo:");
            Halo halo = new Halo();
            halo.Objetivo();
            halo.Jugar();
            
            Console.WriteLine("\nLeague of legends:");
            LeagueofLegends lol = new LeagueofLegends();
            lol.Objetivo();
            lol.Jugar();

            Console.WriteLine("\nMinecraft");
            Minecraft maincra = new Minecraft();
            maincra.Objetivo();
            maincra.Jugar();
        }
    }
}
