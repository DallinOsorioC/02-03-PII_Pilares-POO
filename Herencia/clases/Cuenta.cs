using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class Cuenta
    {
        public string NumeroCuenta;
        public string Nombre;
        public decimal Saldo;
        public decimal TasaInteres;

        public Cuenta(string numeroCuenta, string nombre, decimal saldo, decimal tasaInteres)
        {
            NumeroCuenta = numeroCuenta;
            Nombre = nombre;
            Saldo = saldo;
            TasaInteres = tasaInteres;
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
                return;
            }
            Saldo += cantidad;
            Console.WriteLine($"Se han depositado Q{cantidad} en la cuenta {NumeroCuenta}. Saldo actual: Q{Saldo}");
        }
        public decimal CalcularIntereses()
        {
            if (TasaInteres < 0)
            {
                Console.WriteLine("La tasa de interés no puede ser negativa.");
                return 0;
            }
            decimal intereses = Saldo * TasaInteres / 100;
            Console.WriteLine($"Los intereses calculados son: Q{intereses}");
            return intereses;
        }
    }
}
