using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class MenuDocente : Form
    {
        PersonaLogic personaLogic = new PersonaLogic();
        public Persona docente { get; set; }
        public MenuDocente(string docenteUsuario)
        {
            InitializeComponent();
            docente = personaLogic.GetOneByUser(docenteUsuario);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

        private void consultaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPersonales docentesDatosPersonales = new DatosPersonales(docente.ID, ApplicationForm.Modoform.Consulta);
            docentesDatosPersonales.ShowDialog();
        }

        private void modificacionDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPersonales docentesDatosPersonales = new DatosPersonales(docente.ID, ApplicationForm.Modoform.Modificacion);
            docentesDatosPersonales.ShowDialog();
        }

       

        private void ConsultaDeCursosEinscriptosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistroCondicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
