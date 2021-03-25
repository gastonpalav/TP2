using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ReporteAlumnosPorComisiones : Form
    {
        private ComisionLogic comisionLogic;
        private MateriaLogic materiaLogic;
        private AlumnoInscripcionLogic alumnoInscripcionLogic;

        public ReporteAlumnosPorComisiones()
        {
            InitializeComponent();
            this.comisionLogic = new ComisionLogic();
            this.materiaLogic = new MateriaLogic();
            this.alumnoInscripcionLogic = new AlumnoInscripcionLogic();
        }

        private void ReporteAlumnosPorComisiones_Load(object sender, EventArgs e)
        {
            this.rpteAlumnos.RefreshReport();

            this.cboMateria.DataSource = this.materiaLogic.GetAll();

            this.cboMateria.DisplayMember = "Descripcion";

            this.cboMateria.ValueMember = "ID";
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboComision.DataSource = this.comisionLogic.GetAll();

            this.cboComision.DisplayMember = "Descripcion";

            this.cboComision.ValueMember = "ID";
        }

        private void cboComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia) this.cboMateria.SelectedValue;

            Comision comision = (Comision)this.cboComision.SelectedValue;
            
            this.alumnoInscripcionLogic.ObtenerDatosDeAlumnosInscriptosPorCurso(materia.ID, comision.ID);
        }
    }
}