using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class Auto : Vehiculo
    {
        public Auto(string marca) : base(marca) { }

        public void EncenderRadio()
        {
            Console.WriteLine($"{Marca} encendió la radio.");
        }

    }
}
