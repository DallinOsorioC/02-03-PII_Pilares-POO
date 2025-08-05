using EjercicioEnClase_POO.clases;

internal class Program
{
    private static void Main(string[] args)
    {
        //EJERCICIO 1
        /*
        1.Crea una clase Empleado con atributos privados nombre y salario. Usa propiedades para
        que:
        El nombre no se pueda dejar en blanco.
        El salario no sea negativo.
         */
        Console.WriteLine("***************EJERCICIO 1****************\n");
        Empleado empleado = new Empleado();
        empleado.Nombre = "Dallin Osorio";
        empleado.Salario = 100;
        Console.WriteLine("Nombre: " + empleado.Nombre);
        Console.WriteLine("Salario: " + empleado.Salario);

        //EJERCICIO 2
        /*
        2.Modifica la clase CuentaBancaria para que tenga:
        Un límite de retiro diario.
        Un método MostrarSaldo() que indique cuánto queda.
         */
        Console.WriteLine("\n\n***************EJERCICIO 2****************\n");
        CuentaBancaria cuentaBancaria = new CuentaBancaria();
        cuentaBancaria.Saldo = 5000.0;
        Console.WriteLine($"Saldo inicial: Q{cuentaBancaria.MostarSaldo()}");
        cuentaBancaria.Retiro = 200.0;
        cuentaBancaria.MostarSaldo();
        Console.WriteLine($"Saldo después del retiro: Q{cuentaBancaria.MostarSaldo()}");

        Console.WriteLine("\n\n***************EJERCICIO 3****************\n");
        //EJERCICIO 3
        /*
        3.Diseña una clase Vehiculo con métodos para Encender() y Apagar(), y una propiedad
        Encendido que sea true o false, controlada internamente.
         */
        Vehiculo vehiculo = new Vehiculo();
        vehiculo.Encender();
        vehiculo.Encender();
        vehiculo.Apagar();
        vehiculo.Apagar();
    }
}