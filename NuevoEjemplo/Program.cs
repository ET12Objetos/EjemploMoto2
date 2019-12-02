using NuevoEjemplo.Biblioteca;
using System;

namespace NuevoEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto miMoto = new Moto("azul");
            Moto miMoto2 = new Moto("negro");
            Persona persona = new Persona //("Diego", miMoto, miMoto2);
            {
                Nombre = "Diego",
                moto1 = miMoto,
                moto2 = miMoto2
            };

            //persona.moto1 = miMoto;
            //persona.moto2 = miMoto2;
            persona.ArrancarMoto(miMoto);
            persona.ArrancarMoto(miMoto2);
        }
    }
}
