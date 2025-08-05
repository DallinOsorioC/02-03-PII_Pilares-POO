using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClase_POO.clases
{
    public class CuentaBancaria
    {
        private double saldo;
        private double retiro;
        private double limiteRetiroDiario = 1000.0;

        public double Saldo
        { 
            set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    Console.WriteLine("El saldo no puede ser negativo.");
                }
            }
        }

        public double Retiro
        {

            set
            {
                if (value > 0 && value <= limiteRetiroDiario)
                {
                    if (saldo >= value)
                    {
                        retiro = value;
                        saldo -= value;
                    }
                    else
                    {
                        Console.WriteLine("Fondos insuficientes para el retiro.");
                    }
                }
                else
                {
                    Console.WriteLine("El monto de retiro debe ser positivo y no exceder el límite diario.");
                }
            }
        }
        
        public double MostarSaldo()
        { 
            return saldo;
        }
    }
}
