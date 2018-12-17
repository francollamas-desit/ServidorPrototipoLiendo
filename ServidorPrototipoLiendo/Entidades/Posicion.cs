using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServidorPrototipoLiendo.Entidades
{
    public class Posicion
    {
        public Posicion(double lat, double longitud)
        {
            this.Latitud = lat;
            this.Longitud = longitud;
        }

        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
