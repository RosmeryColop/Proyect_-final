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
        public string Fecha_Hora { get; set; }//almacena la fecha y la hora
        public string Temperatura { get; set; }
        public string Presion { get; set; }
        public string Sintomas { get; set; }

        public string Diagnostico { get; set; }//almacena la enfermedad que diagnostica el doctor
        public string Tratamiento { get; set; }//la cura para la enfermedad
        public List<Receta> Recetas { get; set; }
        public string Proxima_visita { get; set; }//siguiente cita
        public string Costo { get; set; }
        public List<string> Galeria { get; set; }//imagenes almacenadas por el doctor

    }
}