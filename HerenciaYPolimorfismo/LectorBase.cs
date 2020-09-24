using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaYPolimorfismo
{
    public class LectorBase
    {
        public string NombreArchivo { get; set; }

        public string NombreDirectorio { get; set; }

        public LectorBase(string nombreArchivo, string nombreDirectorio)
        {
            this.NombreArchivo = nombreArchivo;
            this.NombreDirectorio = nombreDirectorio;
        }
    }
}
