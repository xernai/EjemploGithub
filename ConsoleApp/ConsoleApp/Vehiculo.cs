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

        public Vehiculo(decimal velocidadMaxima)
        {
            VelocidadMaxima = velocidadMaxima;
        }
    }
}
