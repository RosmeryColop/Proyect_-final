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
        static List<Pacientes> pacientesTemp = new List<Pacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string archivo = Server.MapPath("pacientes.json");
            //StreamReader jsonStream = File.OpenText(archivo);
            //string json = jsonStream.ReadToEnd();
            //jsonStream.Close();
            //pacientesTemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }

        private void GUARDAR()
        {
            string json = JsonConvert.SerializeObject(pacientesTemp);
            string archivo = Server.MapPath("pacientes.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            paciente.Nombre = TextBoxPacienteNombre.Text;
            paciente.Apellido = TextBoxPacienteApellido.Text;
            paciente.Direccion = TextBoxPacienteDireccion.Text;
            paciente.Fecha_nacimiento = TextBoxPacienteNacimiento.Text;
            paciente.NIT = Convert.ToInt32(TextBoxPacienteNIT.Text);
            paciente.Telefono = Convert.ToInt32(TextBoxPacienteTelefono.Text);

            pacientesTemp.Add(paciente);

            GUARDAR();
        }
    }
}