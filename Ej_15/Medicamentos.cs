using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ej_15
{
    public class Medicamentos
    {
        public string Cod_Medicamento { get; set; }
        public string Ingredientes { get; set; }
        public string Labratorio { get; set; }
        public List<Enfermedades> enfermedades { get; set; }

    }

    public class Enfermedades
    {
    }
}