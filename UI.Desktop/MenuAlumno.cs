using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MenuAlumno : Form
    {
        public MenuAlumno()
        {
            InitializeComponent();
        }

        private void inscribirseAUnaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion();

            alumnoInscripcion.Show();
        }
    }
}