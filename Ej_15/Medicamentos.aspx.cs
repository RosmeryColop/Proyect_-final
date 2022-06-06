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
	public partial class Medicamentos1 : System.Web.UI.Page
	{
        static List<Medicamentos> medicamentosTemp = new List<Medicamentos>();
        static List<Enfermedades> enfermedades = new List<Enfermedades>();
        static List<Enfermedades> enfermedadesTemp = new List<Enfermedades>();
        private void LeerJson()
        {

            string archivo = Server.MapPath("Medicamentos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            medicamentosTemp = JsonConvert.DeserializeObject<List<Medicamentos>>(json);
        }

        private void GuardarJson()
        {

            string json = JsonConvert.SerializeObject(medicamentosTemp);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Page_Load(object sender, EventArgs e)
		{
            
        }
        void LimpiarCajas()
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Medicamentos medicamento = new Medicamentos()
            {
                Cod_Medicamento = TextBox1.Text,
                Ingredientes = TextBox2.Text,
                Labratorio = TextBox3.Text,
                enfermedades = enfermedadesTemp.ToArray().ToList()
            };
            medicamentosTemp.Add(medicamento);
            GuardarJson();
            enfermedadesTemp.Clear();
            LimpiarCajas();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Enfermedades enfermedades = new Enfermedades();
            enfermedades.Nombre = TextBox4.Text;
            enfermedadesTemp.Add(enfermedades);
            TextBox4.Text = "";
        }
    }
}