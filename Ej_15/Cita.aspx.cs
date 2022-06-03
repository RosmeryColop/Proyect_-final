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
    public partial class Cita : System.Web.UI.Page
    {
        static List<Agenda> Agendas = new List<Agenda>();
        static List<Agenda> Auxiliar = new List<Agenda>();
        static List<string> HorasDisponibles = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            leer();
            InicializarHoras();
            Auxiliar = Agendas.FindAll(c => c.Fecha == Calendar1.SelectedDate.ToString("dd/MM"));
            for (int i = 0; i < Auxiliar.Count; i++)
            {
                for (int j = 0; j < HorasDisponibles.Count; j++)
                {
                    if (Auxiliar[i].Hora == HorasDisponibles[j])
                        HorasDisponibles.RemoveAt(j);
                }
                
            }
            DropDownListHora.DataSource = null;
            DropDownListHora.DataBind();

            DropDownListHora.DataSource = HorasDisponibles;
            DropDownListHora.DataBind();
        }
        public void guardar()
        {
            string json = JsonConvert.SerializeObject(Agendas);
            string archivo = Server.MapPath("Agenda.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        public void leer()
        {
            string archivo = Server.MapPath("Agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            Agendas = JsonConvert.DeserializeObject<List<Agenda>>(json);
        }
        public void InicializarHoras()
        {
            HorasDisponibles.Clear();
            HorasDisponibles.Add("8:00 am");
            HorasDisponibles.Add("9:00 am");
            HorasDisponibles.Add("10:00 am");
            HorasDisponibles.Add("11:00 am");

            HorasDisponibles.Add("1:00 pm");
            HorasDisponibles.Add("2:00 pm");
            HorasDisponibles.Add("3:00 pm");
            HorasDisponibles.Add("4:00 pm");
        }

        protected void ButtonAgregarCita_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.NIT = TextBoxNIT.Text;
            agenda.Fecha = Calendar1.SelectedDate.ToString("dd/MM");
            agenda.Hora = DropDownListHora.SelectedValue;
            Agendas.Add(agenda);
            guardar();
        }
    }
}