using System;
using System.Collections.Generic;
using System.Text;

namespace NuevoEjemplo.Biblioteca
{
    public class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set {
                if (!string.IsNullOrEmpty(nombre))
                    nombre = value;
                else
                    throw new Exception("El nombre no debe ser cadena vacia");
            }
        }
        public Moto moto1 { get; set; }
        public Moto moto2 { get; set; }

        public void ArrancarMoto(Moto unaMoto)
        {
            unaMoto.Arrancar();
        }

        public Persona()
        {

        }
        
        public Persona(string nombre, Moto unaMoto1, Moto unaMoto2)
        {
            this.moto1 = unaMoto1;

            this.moto2 = unaMoto2;

            if (!string.IsNullOrEmpty(nombre))
                this.nombre = nombre;
            else
                throw new Exception("El nombre no debe ser cadena vacia");
        }
    }
}
