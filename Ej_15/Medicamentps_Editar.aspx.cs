using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace Ej_15
{
    public partial class Medicamentps_Editar : System.Web.UI.Page
    {
        static List<Medicamentos> medicamentosTemp = new List<Medicamentos>();
       
        static List<Enfermedades> enfermedadesTemp = new List<Enfermedades>();

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
        private void GuardarJson()
        {

            string json = JsonConvert.SerializeObject(medicamentosTemp);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            bool b = false;
            Medicamentos medicamento = medicamentosTemp.Find(c => c.Cod_Medicamento == TextBox1.Text);
            if (medicamento != null)
            {
                TextBox2.Text = medicamento.Ingredientes;
                TextBox3.Text = medicamento.Labratorio;

                b = true;
            }
            if (!b)
            {
                TextBox1.Text = "";
                Response.Write("<script>alert('No se encuentra el codigo')</script>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cod_Seleccionado = TextBox1.Text;
            int seleccion = medicamentosTemp.FindIndex(j => j.Cod_Medicamento == cod_Seleccionado);
            if (seleccion != -1)
            {
                medicamentosTemp[seleccion].Ingredientes = TextBox2.Text;
                medicamentosTemp[seleccion].Labratorio = TextBox3.Text;
                medicamentosTemp[seleccion].enfermedades = enfermedadesTemp.ToArray().ToList();
            }
            GuardarJson();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Enfermedades enfermedades = new Enfermedades();
            enfermedades.Nombre = TextBox4.Text;
            enfermedadesTemp.Add(enfermedades);
            TextBox4.Text = "";
        }
    }
}