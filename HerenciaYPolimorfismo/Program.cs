using System;

namespace HerenciaYPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ILector lector = new LectorTxt("archivo.txt","archivostxt");

            lector.AbrirConexion();
            lector.Escribir();
            lector.Leer();

            lector = new LectorXml("archivo.xml", "archivosxml");

            lector.AbrirConexion();
            lector.Escribir();
            lector.Leer();


            Console.ReadLine();
        }
    }
}
