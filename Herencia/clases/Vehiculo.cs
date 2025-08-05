using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class Vehiculo
    {
         public string Marca { get; set; }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }

        public void Avanzar()
        {
            Console.WriteLine($"{Marca} ha sido encendido.");
        }
    }
}
