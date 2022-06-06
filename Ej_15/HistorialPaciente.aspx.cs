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
    public partial class HistorialPaciente : System.Web.UI.Page
    {
        static List<Pacientes> pacientesTemp = new List<Pacientes>();
        static List<Historialpaciente> historialTemp = new List<Historialpaciente>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("historialpaciente.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            historialTemp = JsonConvert.DeserializeObject<List<Historialpaciente>>(json);

            foreach(Historialpaciente historial in historialTemp)
            {
                Label1.Text = historial.NIT;
            }
        }
    }
}