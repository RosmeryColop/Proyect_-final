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
    public partial class Mostrar_historial : System.Web.UI.Page
    {
        static List<Historialpaciente> HistorialTemp = new List<Historialpaciente>();
        protected void Page_Load(object sender, EventArgs e)
        {
            LeerJson();
        }
        private void LeerJson()
        {

            /*string archivo = Server.MapPath("Historial.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
           HistorialTemp = JsonConvert.DeserializeObject<List<Historialpaciente>>(json);*/

            string archivo = Server.MapPath("Historial.json");

            try
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (json.Length > 0)
                {
                    HistorialTemp = JsonConvert.DeserializeObject<List<Historialpaciente>>(json);
                }
            }
            catch (Exception e)
            {

            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Historialpaciente historialpaciente = new Historialpaciente();
            historialpaciente.ID = TextBox1.Text;

        }
    }
}