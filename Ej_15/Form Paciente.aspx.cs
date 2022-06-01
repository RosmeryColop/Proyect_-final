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
            string archivo = Server.MapPath("pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientesTemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
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

            TextBoxPacienteNombre.Text = "";
            TextBoxPacienteApellido.Text = "";
            TextBoxPacienteDireccion.Text = "";
            TextBoxPacienteNacimiento.Text = "";
            TextBoxPacienteNIT.Text = "";
            TextBoxPacienteTelefono.Text = "";
        }

        protected void ButtonACTUALIZAR_Click(object sender, EventArgs e)
        {
            //foreach (var paciente in pacientesTemp)
            //{
                Pacientes paciente = pacientesTemp.Find(c => c.NIT == Convert.ToInt32(TextBoxBuscarNIT.Text));

                if (paciente != null)
                {
                    paciente.Nombre = TextBoxNombreBuscado.Text;
                    paciente.Apellido = TextBoxApellidoBuscado.Text;
                    paciente.Direccion = TextBoxDireccionBuscada.Text;
                    paciente.Fecha_nacimiento = TextBoxFechaBuscada.Text;
                    paciente.Telefono = Convert.ToInt32(TextBoxTelefonoBuscado.Text);

                    GUARDAR();

                    Response.Write("<script>alert('PACIENTE ACTUALIZADO :D !')</script>");
                    TextBoxBuscarNIT.Text = "";
                    TextBoxNombreBuscado.Text = "";
                    TextBoxApellidoBuscado.Text = "";
                    TextBoxFechaBuscada.Text = "";
                    TextBoxDireccionBuscada.Text = "";
                    TextBoxTelefonoBuscado.Text = "";
                }
            //}
        }

        protected void ButtonBUSCAR_Click(object sender, EventArgs e)
        {
            bool encontrado = false;

            Pacientes paciente = pacientesTemp.Find(c => c.NIT == Convert.ToInt32(TextBoxBuscarNIT.Text));
            if (paciente != null)
            {
                TextBoxNombreBuscado.Text = paciente.Nombre;
                TextBoxApellidoBuscado.Text = paciente.Apellido;
                TextBoxFechaBuscada.Text = paciente.Fecha_nacimiento;
                TextBoxDireccionBuscada.Text = paciente.Direccion;
                TextBoxTelefonoBuscado.Text = Convert.ToString(paciente.Telefono);
                encontrado = true;
            }

            if(!encontrado)
            {
                Response.Write("<script>alert('NO SE ENCUENTRA EL PACIENTE!')</script>");
                TextBoxBuscarNIT.Text = "";
                TextBoxNombreBuscado.Text = "";
                TextBoxApellidoBuscado.Text = "";
                TextBoxFechaBuscada.Text = "";
                TextBoxDireccionBuscada.Text = "";
                TextBoxTelefonoBuscado.Text = "";
            }
        }
    }
}