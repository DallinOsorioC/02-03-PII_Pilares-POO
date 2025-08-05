using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class Gerente : Empleado
    {
        public Gerente(string nombre, decimal salario) : base(nombre, salario) { }

        public void TomarDecision()
        {
            Console.WriteLine($"{Nombre} está tomando una decisión importante.");
        }

    }
}
