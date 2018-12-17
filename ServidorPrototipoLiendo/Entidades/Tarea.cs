using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServidorPrototipoLiendo.Entidades
{
    public class Tarea
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Posicion Ubicacion { get; set; }
        public Posicion UbicacionActual { get; set; }
    }
}
