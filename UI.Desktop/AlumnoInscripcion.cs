using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class AlumnoInscripcion : Form
    {
        #region Constructors

        public AlumnoInscripcion()
        {
            InitializeComponent();
        }

        public AlumnoInscripcion(Usuario usuario)
        {
            this.usuAlumno = usuario;

            this.materiaLogic = new MateriaLogic();

            this.comisionLogic = new ComisionLogic();

            this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();

            this.LlenarCboComision();

            //this.LlenarCboMaterias();
        }

        #endregion Constructors

        #region Properties

        public Usuario usuAlumno { set; get; }

        public AlumnoInscripcion alumnoInscripcion { get; set; }

        public Curso cursoAInscribir { get; set; }

        private MateriaLogic materiaLogic { get; set; }

        private ComisionLogic comisionLogic { get; set; }

        private CursoLogic cursoLogic { get; set; }

        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set; }

        #endregion Properties

        #region ComboBox

        private void LlenarCboMaterias()
        {
            this.cboMaterias.DataSource = this.materiaLogic.GetAll();
        }

        private void LlenarCboComision()
        {
            this.cboComision.DataSource = this.comisionLogic.GetAll();
        }

        #endregion

        #region Button Actions

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            this.Inscribir();
        }

        #endregion Button Actions

        #region Other Methods

        private void Inscribir()
        {
            Business.Entities.Curso curso = cboComision.SelectedItem as Business.Entities.Curso;

            if (this.cboComision.SelectedItem != null && this.cboMaterias.SelectedItem != null)
            {
                if (curso.Cupo > 0)
                {
                    Business.Entities.AlumnoInscripcion inscripcion = new Business.Entities.AlumnoInscripcion();

                    this.AlumnoInscripcionLogic.Inscribir(inscripcion);
                }
            }
        }

        #endregion

        private void cboMaterias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cboComision.Enabled = true;

            List<Business.Entities.Curso> comDisponibles = this.cursoLogic.BuscarComisionesPorMateria(this.cboMaterias.SelectedItem.ToString());

            this.cboComision.DataSource = comDisponibles;
        }
    }
}