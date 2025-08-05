using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClase_POO.clases
{
    public class Vehiculo
    {
        private bool encendido = false;
        public bool Encendido
        {
            get { return encendido; }
            private set { encendido = value; }
        }

        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("El vehículo ha sido encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }
        public void Apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("El vehículo ha sido apagado.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está apagado.");
            }
        }
    }
}
