using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class Empleado
    {
        /*
         1.Crea una clase Empleado con propiedades Nombre y Salario. Luego crea:
        Una clase Gerente que tenga un método TomarDecision().
        Una clase Desarrollador con método Programar().
         */
        private string nombre;
        private double salario;

        public string Nombre { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, decimal salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

    }
}
