using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MenuAdministrador_Shown(object sender, EventArgs e)
        {
            //formLogin formLogin = new formLogin();
            //formLogin.Show();
        }

        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void administracionDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.Show();
        }

        private void administracionDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docentes docentes = new Docentes();
            docentes.Show();
        }

        private void administracionDeEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades especialidades = new Especialidades();
            especialidades.Show();
        }

        private void administracionDePlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.Show();
        }

        private void administracionDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            materias.Show();
        }

        private void administracionDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comisiones comisiones = new Comisiones();
            comisiones.Show();
        }

        private void administracionDeCursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Curso curso = new Curso();
            curso.Show();
        }
    }
}