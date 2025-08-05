using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class CuentaAhoro : Cuenta
    {
        public CuentaAhoro(string numeroCuenta, string nombre, decimal saldo, decimal TasaInteres)  : base(numeroCuenta, nombre, saldo, TasaInteres) { }
        public decimal CalcularIntereses()
        {
            if (TasaInteres < 0)
            {
                Console.WriteLine("La tasa de interés no puede ser negativa.");
                return 0;
            }
            decimal intereses = Saldo * TasaInteres / 100;
            Console.WriteLine($"Los intereses calculados para la CUENTA DE AHORRO son: Q{intereses}");
            return intereses;
        }
    }
}
