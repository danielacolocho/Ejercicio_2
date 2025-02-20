using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._2_CocheDeportivo20262996
{
    internal class CocheDeportivo : Coche
    {
        public CocheDeportivo(string marca, string modelo, int velocidadMaxima)
        : base(marca, modelo, velocidadMaxima)
        {
        }

        public void Frena()
        {
            VelocidadActual = 0;
            Console.WriteLine("Velocidad actual: " + VelocidadActual);

        }
    }
}
