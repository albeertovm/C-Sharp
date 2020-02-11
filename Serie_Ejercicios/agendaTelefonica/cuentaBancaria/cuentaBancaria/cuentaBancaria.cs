using System;
using System.Collections.Generic;
using System.Text;

namespace cuentaBancaria
{
    class CuentaBancaria
    {
        private string Nombre { get; } //Tipo string a Nombre debido a que no se realizarán operaciones con el nombre de la cuenta
        private int Saldo { get; set; }
        public CuentaBancaria(string nombre, int saldo) { //Constructor de la clase CuentaBancaria
            Nombre = nombre;
            Saldo = saldo;
            MostrarInformacion();
        }
        public void MostrarInformacion() {
            Console.WriteLine("Cuenta: {0:C} Saldo: {1:C}", Nombre, Saldo); //Información de la cuenta
        }
        public void Deposito() {
            int deposito = 500; 
            Saldo += deposito; //Se deposita el dinero
            Console.Write("Deposito exitoso de {0:C} a ", deposito);
            MostrarInformacion();
        }
        public void Retiro() {
            int retiro = 1000;
            if (Saldo > retiro) { //Se valida que la cuenta tenga más dinero del que se va a retirar
                Saldo -= retiro; //Se retira el dinero
                Console.Write("Retiro exitoso de {0:C} a ", retiro);
                MostrarInformacion();
            }
            else
            {
                Console.Write("Retiro fallido de {0:C} a ", retiro);
                MostrarInformacion();
            }
        }
    }
}
