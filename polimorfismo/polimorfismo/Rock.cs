using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo
{
    class Rock : Musica
    {
        public override void Cantar() {
            Console.WriteLine("Cantando Duality...");
        }
        public override void VenderAlbum() {
            Console.WriteLine("Realizando conciertos de nuevo álbum...");
        }
        public override void ConseguirFans() 
        {
            Console.WriteLine("Curando el hambre mundial...");
        }
        public virtual void SerFamoso() 
        {
            Console.WriteLine("Ganando varios grammys...");
        }
    }
}
