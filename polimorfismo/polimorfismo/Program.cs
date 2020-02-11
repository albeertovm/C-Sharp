using System;

namespace polimorfismo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Rock:");
            Rock r1 = new Rock();
            r1.Cantar();
            r1.ConseguirFans();
            r1.DescubrirTalentos();
            r1.VenderAlbum();
            r1.SerFamoso();
            Console.WriteLine("\nBlackMetal:");
            BlackMetal bm1 = new BlackMetal();
            bm1.ConseguirFans();
            bm1.SerFamoso();
            bm1.DescubrirTalentos();
            Console.WriteLine("\nPop:");
            Pop p1 = new Pop();
            p1.Cantar();
            p1.ConseguirFans();
            p1.DescubrirTalentos();
            p1.VenderAlbum();
            Console.ReadKey();
        }
    }
}
