using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;


namespace UI.Desktop
{
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        private List<Business.Entities.Curso> listaCursos;
        private List<Business.Entities.Persona> listaDocentes;
        
        public DocenteCursoDesktop()
        {
            InitializeComponent();
            CursoLogic curso = new CursoLogic();
            listaCursos = curso.GetAll();
            this.cboCurso.DataSource = listaCursos;
            this.cboCurso.ValueMember = "CursoDescripcion";
            this.cboCurso.DisplayMember = "CursoDescripcion";
            PersonaLogic docente = new PersonaLogic();
            listaDocentes = docente.GetAllPersonasByType(Persona.TipoPersonas.Docente);
            this.cboDocente.DataSource = listaDocentes;
            this.cboDocente.ValueMember = "Legajo";
            this.cboDocente.DisplayMember = "Legajo";

            this.cboCargos.DataSource = Enum.GetNames(typeof(DocenteCurso.TiposCargos));
            //this.cboCargos.ValueMember = "Cargo";
            //this.cboCargos.DisplayMember = "Cargo";

        }


        private Business.Entities.DocenteCurso  _docentecursoActual;

        public Business.Entities.DocenteCurso DocenteCursoActual

        {
            get { return _docentecursoActual; }
            set { _docentecursoActual = value; }
        }

        public DocenteCursoDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public DocenteCursoDesktop(int ID,Modoform modo) :this()
        {
            this.Modo= modo;
            DocentesCursosLogic docentecursoLogic = new DocentesCursosLogic();
            this.DocenteCursoActual = docentecursoLogic.GetOneD(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.DocenteCursoActual.ID.ToString();
            this.cboCurso.SelectedValue = this.DocenteCursoActual.Curso.CursoDescripcion;
            this.cboDocente.SelectedValue = this.DocenteCursoActual.LegajoDocente;
            this.cboCargos.SelectedItem = this.DocenteCursoActual.Cargo.ToString();
            switch (this.Modo)
            {
                case Modoform.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case Modoform.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case Modoform.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;

            }

        }

        public override void MapearADatos()
        {
            switch(this.Modo)
            {
                case Modoform.Alta:
                    Business.Entities.DocenteCurso docentecurso = new Business.Entities.DocenteCurso();
                    this.DocenteCursoActual = docentecurso;
                    this.DocenteCursoActual.State = BusinessEntity.States.New;
                    break;
                case Modoform.Modificacion:
                    this.DocenteCursoActual.State = BusinessEntity.States.Modified;
                    break;
                case Modoform.Baja:
                    this.DocenteCursoActual.State = BusinessEntity.States.Deleted;
                    break;

            }

            if (this.Modo == Modoform.Alta || Modo == Modoform.Modificacion)
            {
                DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), this.cboCargos.SelectedValue.ToString());

                DocenteCursoActual.Docente = new Persona();
                int itemSeleccionadoDocente = cboDocente.SelectedIndex;
                DocenteCursoActual.Docente.ID = this.listaDocentes[itemSeleccionadoDocente].ID;
                DocenteCursoActual.Curso = new Business.Entities.Curso();
                int itemSeleccionadoCurso = cboCurso.SelectedIndex;
                DocenteCursoActual.Curso.ID = this.listaCursos[itemSeleccionadoCurso].ID;
            }

        }

        public override bool Validar()
        {
            if (this.cboCurso.SelectedValue==null || this.cboDocente.SelectedValue==null || this.cboCargos.SelectedValue== null)
            {
                this.Notificar("INFORMACION INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
            
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                DocentesCursosLogic docentecursoLogic = new DocentesCursosLogic();
                docentecursoLogic.Save(this.DocenteCursoActual);
                this.Notificar("GUARDADO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo == Modoform.Alta || this.Modo == Modoform.Modificacion)
            {
                this.GuardarCambios();
            }
            else if (this.Modo == Modoform.Baja)
            {
                this.Eliminar();
            }
        }

        private void Eliminar()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta inscripcion a un curso?.", "Eliminar docente curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    DocentesCursosLogic docentecursoLogic = new DocentesCursosLogic();
                    docentecursoLogic.Delete(this.DocenteCursoActual.ID);
                    this.Close();
                }
                catch (Exception ex)
                {
                    this.Notificar("ERROR", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
