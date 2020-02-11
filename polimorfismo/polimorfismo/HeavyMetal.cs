using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo
{
    class BlackMetal : Rock
    {
        public override void SerFamoso()
        {
            Console.WriteLine("Quemando iglesias en Noruega...");
        }
        public override void ConseguirFans()
        {
            Console.WriteLine("Realizando rituales em público");
        }
        public override void DescubrirTalentos()
        {
            Console.WriteLine("Haciendo sacrificios humanos...");
        }

    }
}
