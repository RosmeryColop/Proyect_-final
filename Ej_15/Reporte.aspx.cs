using Ej_15.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ej_15
{
    public partial class Reporte : System.Web.UI.Page
    {
        static public List<Sintomas> CodSintoma = new List<Sintomas>();
        public static List<Agenda> Agenda = new List<Agenda>();
        public static List<Pacientes> Paciente0 = new List<Pacientes>();
        public static List<Historialpaciente> HistorialP = new List<Historialpaciente>();
        public static List<Sintomas> SintomaP = new List<Sintomas>();
        public static List<Medicamentos> MedicamentoP = new List<Medicamentos>();
        protected void Page_Load(object sender, EventArgs e)
        {
            leerJson();
        }
        private void leerJson()
        {
            string archivo = Server.MapPath("Datos.Json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            CodSintoma = JsonConvert.DeserializeObject<List<Sintomas>>(json);
        }
        private void ObtenerEnfermedadesComunes()
        {
           /* List<EnfermedadCom> Enfermedad = new List<EnfermedadCom>();
            foreach (var a in Historialpaciente.Diagnostico)
            {
                EnfermedadCom e = new EnfermedadCom();
                e.Enfermedad = a.Diagnostico;
                if (enfermedadesComunes.Find(p => p.Enfermedad == a.Diagnostico) != null)
                {
                    continue;
                }
                foreach (var b in Lectura.Historial)
                {

                    if (a.Diagnostico == b.Diagnostico && Enfermedad.Find(p => p.Enfermedad == a.Diagnostico) != null)
                    {
                        continue;
                    }
                    else if (a.Diagnostico == b.Diagnostico)
                    {
                        e.Pacientes++;
                    }
                }
                enfermedadesComunes.Add(e);
            }
            GridView1.DataSource = enfermedadesComunes;
            GridView1.DataBind();*/
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {


        }
    }
}