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
    public partial class Form_Paciente : System.Web.UI.Page
    {
        static List<Pacientes> pacientes = new List<Pacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string archivo = Server.MapPath("pacientes.json");
            //StreamReader jsonStream = File.OpenText(archivo);
            //string json = jsonStream.ReadToEnd();
            //jsonStream.Close();
            //pacientes = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }

        private void GUARDAR()
        {
            string json = JsonConvert.SerializeObject(pacientes);
            string archivo = Server.MapPath("pacientes.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}