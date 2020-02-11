using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo
{
    class Pop : Musica
    {
        public override void Cantar() 
        {
            Console.WriteLine("Cantando Blinding lights...");
        }
        public override void VenderAlbum() 
        {
            Console.WriteLine("Realizando entrevistas en vivo...");
        }
        public override void ConseguirFans() 
        {
            Console.WriteLine("Realizando firma de autógrafos...");
        }
        public override void DescubrirTalentos()
        {
            Console.WriteLine("Investigando gente en YouTube...");
        }
    }
}
