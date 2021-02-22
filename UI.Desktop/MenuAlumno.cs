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
    public partial class MenuAlumno : Form
    {
        PersonaLogic personaLogic = new PersonaLogic();
        public MenuAlumno(string usuAlumno)
        {
            InitializeComponent();
            Usualumno = usuAlumno;
            
        }

        public string Usualumno { get; set; }
        private void inscribirseAUnaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usuAlumno = personaLogic.GetOneByUser(Usualumno);
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion(usuAlumno);
            alumnoInscripcion.ShowDialog();
        }




    }
}
