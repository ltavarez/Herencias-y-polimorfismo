using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaYPolimorfismo
{
    public class Perro : Animal
    {
        public Perro(DateTime fechaNacimiento, string nombre, string color) : base(fechaNacimiento,nombre,color)
        {
        }

        public void Ladrar()
        {
            Console.WriteLine("Jau jau");
        }
    }
}
