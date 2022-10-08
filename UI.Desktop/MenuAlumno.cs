using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MenuAlumno : Form
    {
        private PersonaLogic personaLogic = new PersonaLogic();

        public MenuAlumno(string AlumnoUsuario)
        {
            InitializeComponent();
            Alumno = personaLogic.GetOneByUser(AlumnoUsuario);
        }

        public Persona Alumno { get; set; }

        private void inscribirseAUnaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion(Alumno);
            alumnoInscripcion.ShowDialog();
        }

        private void consultaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPersonales alumnosDatosPersonales = new DatosPersonales(Alumno.ID, ApplicationForm.Modoform.Consulta);
            alumnosDatosPersonales.ShowDialog();
        }

        private void modificacionDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPersonales alumnosDatosPersonales = new DatosPersonales(Alumno.ID, ApplicationForm.Modoform.Modificacion);
            alumnosDatosPersonales.ShowDialog();
        }

        private void consultaEstadoAcademicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoAcademico estadoAcademico = new EstadoAcademico(Alumno);
            estadoAcademico.ShowDialog();
        }

        private void reporteMateriasInscriptasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteComisionesAlumno reporteComisionesAlumno = new ReporteComisionesAlumno(Alumno);
            reporteComisionesAlumno.ShowDialog();
            
        }
    }
}