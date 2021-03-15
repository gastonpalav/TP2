using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class CondicionesAlumnosDesktop : ApplicationForm
    {

        private enum Condiciones
        {
            Libre,
            Regular,
            Aprobado
        };

        public CondicionesAlumnosDesktop()
        {
            InitializeComponent();
            cboCondicion.DataSource = Enum.GetValues(typeof(Condiciones));
        }

        public CondicionesAlumnosDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public DocenteCurso DocenteCursoEntity { get; set; }
        public int IDAlumnoInscripcion { get; set; }

        public CondicionesAlumnosDesktop(int ID, Modoform modo) : this()
        {
            this.Modo = modo;
            DocentesCursosLogic docenteCursosLogic = new DocentesCursosLogic();
            this.DocenteCursoEntity = docenteCursosLogic.GetOne(ID);
            IDAlumnoInscripcion = DocenteCursoEntity.AlumnoInscripcionID;

            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtBoxID.Text = DocenteCursoEntity.ID.ToString();
            txtBoxMateria.Text = DocenteCursoEntity.CursoDescripcion.ToString();
            txtBoxLegajo.Text = DocenteCursoEntity.LegajoAlumno.ToString();
            txtBoxNota.Text = DocenteCursoEntity.AlumnoNota.ToString();
            txtBoxCargo.Text = DocenteCursoEntity.Cargo.ToString();
            cboCondicion.SelectedIndex = cboCondicion.FindString(DocenteCursoEntity.AlumnoCondicion);



            switch (this.Modo)
            {
                case Modoform.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;

                case Modoform.Consulta:


                    cboCondicion.DropDownStyle = ComboBoxStyle.Simple;
                    cboCondicion.Enabled = false;
                    txtBoxNota.Enabled = false;
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            this.DocenteCursoEntity.State = BusinessEntity.States.Modified;
            DocenteCursoEntity.AlumnoInscripcion = new Business.Entities.AlumnoInscripcion
            {
                ID = IDAlumnoInscripcion,
                Nota = Convert.ToInt32(txtBoxNota.Text),
                Condicion = cboCondicion.SelectedItem.ToString()
            };
        }

        public override bool Validar()
        {
            if (this.cboCondicion.SelectedValue == null || this.txtBoxNota == null && Convert.ToInt32(this.txtBoxNota.Text) >= 0)
            {
                this.Notificar("INFORMACION INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                AlumnoInscripcionLogic Logic = new AlumnoInscripcionLogic();
                Business.Entities.AlumnoInscripcion alumnoInscripcion = new Business.Entities.AlumnoInscripcion();
                alumnoInscripcion.Nota = DocenteCursoEntity.AlumnoNota;
                alumnoInscripcion.Condicion = DocenteCursoEntity.AlumnoCondicion;
                alumnoInscripcion.ID = DocenteCursoEntity.AlumnoInscripcionID;
                Logic.Update(alumnoInscripcion);
                this.Notificar("GUARDADO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }
    }
}