using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.clases
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca) : base(marca) { }
        public void HacerCaballito()
        {
            Console.WriteLine($"{Marca} está haciendo un caballito.");
        }
    }
}
