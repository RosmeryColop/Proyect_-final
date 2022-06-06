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
    public partial class Editar : System.Web.UI.Page
    {
        static public List<Sintomas> CodSintoma = new List<Sintomas>();
        static public List<Sintomas> SintomaTemp = new List<Sintomas>();
        static string sint;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Datos.Json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            CodSintoma = JsonConvert.DeserializeObject<List<Sintomas>>(json);
        }
        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(CodSintoma);
            string archivo = Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            sint = TextBox1.Text;
            bool encontrado = false;
            Sintomas sintoma01 = CodSintoma.Find(c => c.Cod_Sintomas == sint);
            if (sintoma01 != null)
            {
                TextBox2.Text = sintoma01.Des_Sintomas;
                encontrado = true;
            }
            if (!encontrado)
            {
                TextBox1.Text = "";
                Response.Write("<script>alert('No se encuentra el codigo del sintoma que busca')</script>");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
           
            int sint01 = CodSintoma.FindIndex(j => j.Cod_Sintomas == sint);  
            if (sint01 != -1)
            {
                CodSintoma[sint01].Des_Sintomas = TextBox2.Text;
            }
            Guardar();
            TextBox2.Text = "";
            TextBox1.Text = "";
        }
    }
}