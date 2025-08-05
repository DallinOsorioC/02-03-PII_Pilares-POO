using Herencia.clases;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         EJERCICIO:1
        1.Crea una clase Empleado con propiedades Nombre y Salario. Luego crea
        Una clase Gerente que tenga un método TomarDecision().
        Una clase Desarrollador con método Programar
         */
        Console.WriteLine("***************EJERCICIO 1****************\n");

        Gerente gerente = new Gerente("Dallin Osorio", 15000);
        Desarrollador desarrollador = new Desarrollador("Carrie Medrano", 10000);

        gerente.TomarDecision();
        desarrollador.Programar();

        //EJERCICIO 2
        Console.WriteLine("\n\n***************EJERCICIO 2****************\n");
        /*
        2.Crea una jerarquía de Vehiculo → Auto y Motocicleta.
        Todos los vehículos pueden Avanzar().
        Auto tiene método EncenderRadio().
        Motocicleta tiene método HacerCaballito().
         */
        Auto auto = new Auto("Honda civic");
        Motocicleta motocicleta = new Motocicleta("Yamaha MT-07");

        auto.EncenderRadio();
        motocicleta.HacerCaballito();

        Console.WriteLine("\n\n***************EJERCICIO 3****************\n");
        //EJERCICIO 3
        /*
        3.Implementa una clase Cuenta con método Depositar().

        Luego crea CuentaAhorro y CuentaCorriente que tengan comportamiento distinto en
        un método CalcularIntereses().
         */

        Cuenta cuentaAhorro = new CuentaAhoro("12345", "Dallin Osorio", 1000, 5);
        Cuenta cuentaCorriente = new CuentaCorriente("67890", "Helam Osorio", 2000, 3);
        cuentaAhorro.Depositar(500);
        cuentaCorriente.Depositar(1000);
        cuentaAhorro.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
    }
}