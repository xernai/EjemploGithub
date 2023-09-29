using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroPuertas { get; set; }

        public Vehiculo(decimal velocidadMaxima, int numeroPuertas)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroPuertas = numeroPuertas;
        }
    }
}
