using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ej_15
{
    public class Receta : Medicamentos
    {
        public float Dosis { get; set; }
        public string HorasAdministradas { get; set; }
    }
}