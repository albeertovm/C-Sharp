using System;

namespace cuentaBancaria
{
    class Program
    {
        static void Main()
        {
            CuentaBancaria c1 = new CuentaBancaria("00001",5000); //Instancia de la clase CuentaBancaria
            CuentaBancaria c2 = new CuentaBancaria("00002", 100);
            //Métodos implemetados
            c1.Deposito();
            c1.Retiro();
            c2.Deposito();
            c2.Retiro();
            Console.ReadKey();
        }
    }
}
