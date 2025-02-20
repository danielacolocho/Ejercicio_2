using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio0_PersonaNadadora20262996
{
    public class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo)
        {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;
        }
        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;
        public void Hablar(string texto)
        {
            // se muestra la conversacion a decir
            Console.WriteLine("Voy a decir:" + texto);
        }
        public void Comer(double calorias)
        {
            // se indica las calorias que se ganan al comer
            Console.WriteLine("Ganando" + calorias + "Calorias");
        }
        public void Correr(double calorias)
        {
            // Se indica las calorias que se pierden al correr
            Console.WriteLine("perdiendo" + calorias + "calorias");
            this.Peso = Convert.ToString(calorias / 1000);
        }
    }
}
