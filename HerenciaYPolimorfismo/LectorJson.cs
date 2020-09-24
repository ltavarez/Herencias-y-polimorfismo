using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaYPolimorfismo
{
    public class LectorJson : LectorBase, ILector
    {
        public LectorJson(string nombreArchivo, string nombreDirectorio) : base(nombreArchivo, nombreDirectorio)
        {
        }

        public void Leer()
        {
            Console.WriteLine("Ya lei el archivo json y este es el nombre " + NombreArchivo + " y esta en el directorio " + NombreDirectorio);
            Console.ReadKey();
        }

        public void Escribir()
        {
            Console.WriteLine("Ya escribi el archivo json y este es el nombre " + NombreArchivo + " y esta en el directorio " + NombreDirectorio);
            Console.ReadKey();
        }

        public void AbrirConexion()
        {
            Console.WriteLine("Me conecte al json");
            Console.ReadKey();
        }

    }
}
