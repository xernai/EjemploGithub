using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introudce tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"El nombre es {nombre}");
            
            var coche = new Vehiculo(200, 5, 90);
            Console.WriteLine($"El coche tiene {coche.Cv}");
            Console.ReadKey();
        }
    }
}
