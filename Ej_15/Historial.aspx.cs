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
    public partial class WebForm2 : System.Web.UI.Page
    {
        static List<Enfermedades> enfermedadesTemp = new List<Enfermedades>();

        static List<Historialpaciente> HistorialTemp = new List<Historialpaciente>();

        static List<Medicamentos> medicamentosTemp = new List<Medicamentos>();
        protected void Page_Load(object sender, EventArgs e)
        {
            LeerJson();
        }
        private void LeerJson()
        {

            string archivo = Server.MapPath("Medicamentos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            medicamentosTemp = JsonConvert.DeserializeObject<List<Medicamentos>>(json);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            bool b = false;
            string cod;
            Medicamentos medicamento = medicamentosTemp.Find(c => c.Cod_Medicamento == TextBox1.Text);
            if (medicamento != null)
            {
                b = true;
                cod = medicamento.Cod_Medicamento;
                
                Historialpaciente historial = new Historialpaciente();
                historial.ID= cod;
                HistorialTemp.Add(historial);
                GuardarJson();
                Response.Write("<script>alert('Nom encontrado')</script>");
            }
            if (!b)
            {
                TextBox1.Text = "";
                Response.Write("<script>alert('No se encuentra el codigo')</script>");
            }

        }
        private void GuardarJson()
        {

            string json = JsonConvert.SerializeObject(HistorialTemp);
            string archivo = Server.MapPath("Historial.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}