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
    public partial class Form_Historial_Paciente : System.Web.UI.Page
    {
        static List<Pacientes> pacientesTemp = new List<Pacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientesTemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;

            Pacientes paciente = pacientesTemp.Find(c => c.Codigo == TextBox1.Text);
            if (paciente != null)
            {
                encontrado = true;
                
            }

            if (!encontrado)
            {
                Response.Write("<script>alert('NO SE ENCUENTRA EL PACIENTE!')</script>");
            }
        }
    }
}