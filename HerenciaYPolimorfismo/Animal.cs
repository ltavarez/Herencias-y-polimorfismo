using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaYPolimorfismo
{
    //Esta es la clase base
    public class Animal
    {
        public string Nombre { get; set; }

        public string Color { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Animal(DateTime fechaNacimiento,string nombre, string color)
        {
            this.FechaNacimiento = fechaNacimiento;

            this.Nombre = nombre;

            this.Color = color;
        }

        public int GetEdad()
        {
            DateTime fechaActual = DateTime.Now;

            return fechaActual.Year - FechaNacimiento.Year;
        }

        public void ImprimirNombre()
        {
            Console.WriteLine("Mi nombre es " + Nombre);
        }

        public void ImprimirColor()
        {
            Console.WriteLine("Mi color es " + Color);
        }

    }
}
