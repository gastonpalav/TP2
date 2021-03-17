using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class AlumnoInscripcion : Form


    {

        private List<Materia> listaMaterias;
        private List<Business.Entities.Curso> listaCursos;
        #region Constructors

        public AlumnoInscripcion()
        {
            InitializeComponent();

            //this.materiaLogic = new MateriaLogic();
            //this.comisionLogic = new ComisionLogic();
            //this.cursoLogic = new CursoLogic();
            //this.LlenarCboMaterias();
            //listaCursos = cursoLogic.GetAll();
            //this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();


         
        }

        public AlumnoInscripcion(Persona persona)
        {
            InitializeComponent();
            this.usuAlumno = persona;
            this.materiaLogic = new MateriaLogic();
            this.comisionLogic = new ComisionLogic();
            this.cursoLogic = new CursoLogic();
            this.LlenarCboMaterias();
            listaCursos = cursoLogic.GetAll();
            this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();




        }

        #endregion Constructors

        #region Properties

        public Persona usuAlumno { set; get; }

        public Business.Entities.AlumnoInscripcion alumnoInscripcion { get; set; }

        public Curso cursoAInscribir { get; set; }

        private MateriaLogic materiaLogic { get; set; }

        private ComisionLogic comisionLogic { get; set; }

        private CursoLogic cursoLogic { get; set; }

        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set; }

        #endregion Properties

        #region ComboBox

        private void LlenarCboMaterias()

        {
            MateriaLogic Materia = new MateriaLogic();
            listaMaterias = Materia.GetAll();
            this.cboMaterias.DataSource = listaMaterias;
            this.cboMaterias.ValueMember = "Descripcion";
            this.cboMaterias.DisplayMember = "Descripcion";
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

            try
            {
                if (this.cboComision.SelectedItem != null && this.cboMaterias.SelectedItem != null)
                {
                    if (curso.Cupo > 0)
                    {
                        
                        Business.Entities.AlumnoInscripcion alumnoIns = new Business.Entities.AlumnoInscripcion();
                        alumnoInscripcion = alumnoIns;
                        alumnoInscripcion.State = BusinessEntity.States.New;
                        foreach (var cursos in listaCursos)
                        {
                            if (curso.ID== cursos.ID)
                            {
                                alumnoInscripcion.IDCurso = cursos.ID;
                                alumnoInscripcion.IDAlumno = usuAlumno.ID;
                                if(AlumnoInscripcionLogic.Inscribir(alumnoInscripcion))
                                {
                                    MessageBox.Show("Inscripcion realizada");
                                }
                                else
                                {
                                    MessageBox.Show("Error, ya se ha inscripto a este curso");
                                }
                                
                                

                            }
                        }

                        


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error realizar inscripcion");
                throw ex;
            }
                            
            
        }

        

            #endregion

            private void cboMaterias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                List<Business.Entities.Curso> comDisponibles;
                foreach (var materia in listaMaterias)
                {
                    if((Materia)cboMaterias.SelectedItem==materia)
                    {
                        comDisponibles = this.cursoLogic.BuscarComisionesPorMateria(materia);
                        this.cboComision.DataSource = comDisponibles;
                        this.cboComision.ValueMember = "ComisionDescripcion";
                        this.cboComision.DisplayMember = "ComisionDescripcion";
                        this.cboComision.Enabled = true;
                    }
                }
                 
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al mostrar las comisiones");
                throw ex;
            }
        }
   

        private void cboMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}