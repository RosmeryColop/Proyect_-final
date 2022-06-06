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
    public partial class Sintomas1 : System.Web.UI.Page
    {
        static public List<Sintomas> CodSintoma = new List<Sintomas>();
        static public List<Sintomas> SintomaTemp = new List<Sintomas>();
        string sint;
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
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (CodSintoma.Find(a => a.Cod_Sintomas == txt_Enfermedad.Text)== null ) 
            {
                Sintomas CSintomas = new Sintomas()
                {
                    Cod_Sintomas = txt_Enfermedad.Text,
                    Des_Sintomas = txt_Enfermedad.Text,
                };                                                                      
                CodSintoma.Add(CSintomas);
                Guardar();
            }
            else
            {
                Response.Write("<script> alert('Este sintoma ya esta registrado') </script>");
            }
            txt_sintomas.Text = "";
            txt_Enfermedad.Text = "";
        }

       
    }
}