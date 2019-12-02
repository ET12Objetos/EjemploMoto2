using System;
using System.Collections.Generic;
using System.Text;

namespace NuevoEjemplo.Biblioteca
{
    public class Moto
    {
        public string color { get; set; }

        //true = encendido
        //false = apagado
        public bool estado { get; set; }

        public Moto(string color)
        {
            this.color = color;
            this.estado = false;
            Console.WriteLine($"{estado}");
        }

        public void Apagar()
        {
            if (estado == true)
                estado = false;
            else
                throw new Exception("La moto ya se encuentra apagada");
            Console.WriteLine($"{estado}");
        }

        public void Arrancar()
        {
            Console.WriteLine($"Color: {color} Estado:{estado}");
            if(estado == false)
              estado = true;
            else
                throw new Exception("La moto ya se encuentra encendida");
        }
    }
}
