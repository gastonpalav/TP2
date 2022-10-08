using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ReporteComisionesAlumno : ApplicationForm
    {
        private AlumnoInscripcionLogic logic;

        public ReporteComisionesAlumno()
        {
            InitializeComponent();

            this.logic = new AlumnoInscripcionLogic();
        }

        private void ReporteComisionesAlumno_Load(object sender, EventArgs e)
        {
            
        }

        public ReporteComisionesAlumno(Persona alumno)
        {
            try
            {
                InitializeComponent();

                this.logic = new AlumnoInscripcionLogic();

                this.AlumnoInscripcionBindingSource.DataSource = this.logic.GetAllByAlumno(alumno);
                this.reportViewer1.RefreshReport();


            }
            catch (Exception ex)
            {
                this.Notificar("ERROR", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlumnoInscripcionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}