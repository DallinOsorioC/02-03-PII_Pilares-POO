using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClase_POO.clases
{
    public class Empleado
    {
        private string nombre;
        private double salario;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío o ser nulo.");
                }
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
                else
                {
                    Console.WriteLine("El salario no puede ser negativo.");
                }
            }
        }
    }
}
