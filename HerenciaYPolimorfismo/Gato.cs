using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaYPolimorfismo
{
    public class Gato : Animal
    {
        public Gato(DateTime fechaNacimiento, string nombre, string color) : base(fechaNacimiento, nombre, color)
        {
        }


        public void Maullar()
        {
            Console.WriteLine("Miau miau");
        }
    }
}
