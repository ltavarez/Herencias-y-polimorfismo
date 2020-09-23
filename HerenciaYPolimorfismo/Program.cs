using System;

namespace HerenciaYPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNac =  new DateTime(1993,12,20);
           Perro nuevoPerro = new Perro(fechaNac,"Toby","Amarillo");

            Console.WriteLine(nuevoPerro.GetEdad());

            nuevoPerro.ImprimirColor();
            nuevoPerro.ImprimirNombre();

            DateTime fechaNacGato = new DateTime(2000, 12, 20);
            Gato nuevoGato = new Gato(fechaNacGato, "misu", "negro");

            Console.WriteLine(nuevoGato.GetEdad());

            nuevoGato.ImprimirColor();
            nuevoGato.ImprimirNombre();

            nuevoPerro.Ladrar();

            nuevoGato.Maullar();

            Console.ReadLine();
        }
    }
}
