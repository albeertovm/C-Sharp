using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo
{
    abstract class Musica
    {
        abstract public void Cantar();
        abstract public void VenderAlbum();
        abstract public void ConseguirFans();
        public virtual void DescubrirTalentos()
        {
            Console.WriteLine("Realizando batalla de bandas...");
        }
    }
}
