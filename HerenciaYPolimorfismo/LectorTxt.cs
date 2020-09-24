using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaYPolimorfismo
{
    class LectorTxt : LectorBase, ILector
    {

        public LectorTxt(string nombreArchivo, string nombreDirectorio) : base(nombreArchivo, nombreDirectorio)
        {
        }
        public void Leer()
        {
            Console.WriteLine("Ya lei el archivo txt y este es el nombre " + NombreArchivo + " y esta en el directorio " + NombreDirectorio);
            Console.ReadKey();
        }

        public void Escribir()
        {
            Console.WriteLine("Ya escribi el archivo txt y este es el nombre " + NombreArchivo + " y esta en el directorio " + NombreDirectorio);
            Console.ReadKey();
        }

        public void AbrirConexion()
        {
            Console.WriteLine("Me conecte al txt");
            Console.ReadKey();
        }
    }
}
