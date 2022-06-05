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
    public partial class EliminarCita : System.Web.UI.Page
    {
        static List<Agenda> Agendas = new List<Agenda>();
        static List<Agenda> Auxiliar = new List<Agenda>();
        static List<string> HorasDisponibles = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminarCita_Click(object sender, EventArgs e)
        {
            int indiceEliminar = Agendas.FindIndex(c => c.Fecha == Calendar1.SelectedDate.ToString("dd/MM") && c.Hora == DropDownListHora.SelectedValue);
            Agendas.RemoveAt(indiceEliminar);
            guardar();
            Calendar1.SelectedDate = DateTime.Now;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            leer();
            HorasDisponibles.Clear();
            Auxiliar = Agendas.FindAll(c => c.Fecha == Calendar1.SelectedDate.ToString("dd/MM"));
            for (int i = 0; i < Auxiliar.Count; i++)
                HorasDisponibles.Add(Auxiliar[i].Hora);

            if (HorasDisponibles.Count == 0) HorasDisponibles.Add("SIN CITAS");

            DropDownListHora.DataSource = null;
            DropDownListHora.DataBind();



            DropDownListHora.DataSource = HorasDisponibles;
            DropDownListHora.DataBind();
        }
        public void leer()
        {
            string archivo = Server.MapPath("Agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            Agendas = JsonConvert.DeserializeObject<List<Agenda>>(json);
        }

        public void guardar()
        {
            string json = JsonConvert.SerializeObject(Agendas);
            string archivo = Server.MapPath("Agenda.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}