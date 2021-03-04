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
    }
}
