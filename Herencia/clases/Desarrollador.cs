using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class Desarrollador : Empleado
    {
        public Desarrollador(string nombre, decimal salario) : base(nombre, salario) { }

        public void Programar()
        {
            Console.WriteLine($"{Nombre} está programando una nueva funcionalidad.");
        }
    }
}
