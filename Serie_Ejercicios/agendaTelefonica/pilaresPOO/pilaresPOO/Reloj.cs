using System;
using System.Collections.Generic;
using System.Text;

namespace pilaresPOO
{
    interface IReloj
    {
        //Se utiliza el poliforfismo ya que todos los relojes muestran la hora de diferente manera
        void MostrarHora();
    }
}