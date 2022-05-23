 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ej_15
{
    public class Historialpaciente
    {
        public string ID { get; set; }

        public string NIT { get; set; }
        public string Fecha_Hora { get; set; }
        public string Temperatura { get; set; }
        public string Presion { get; set; }
        public string Sintomas { get; set; }

        public string Diagnostico { get; set; }
        public string Proxima_visita { get; set; }
        public string Costo { get; set; }
        public string Galeria { get; set; }

    }
}