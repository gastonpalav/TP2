using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace UI.Desktop
{
    public partial class DocentesDesktop : ApplicationForm
    {

        private List<Plan> listaPlanes;
        public DocentesDesktop()
        {
            InitializeComponent();
            PlanLogic planLogic = new PlanLogic();
            listaPlanes = planLogic.GetAll();
            this.cboBoxPlan.DataSource = listaPlanes;
            this.cboBoxPlan.ValueMember = "Descripcion";
            this.cboBoxPlan.DisplayMember = "Descripcion";
        }

        public DocentesDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public Persona PersonaEntity { get; set; }

        public DocentesDesktop(int ID, Modoform modo) : this()
        {
            this.Modo = modo;
            PersonaLogic personaLogic = new PersonaLogic();
            this.PersonaEntity = personaLogic.GetOneById(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtBoxID.Text = PersonaEntity.ID.ToString();
            txtBoxApellido.Text = PersonaEntity.Apellido.ToString();
            txtBoxDireccion.Text = PersonaEntity.Direccion.ToString();
            txtBoxEmail.Text = PersonaEntity.Email.ToString();
            txtBoxLegajo.Text = PersonaEntity.Legajo.ToString();
            txtBoxNombre.Text = PersonaEntity.Nombre.ToString();
            txtBoxTelefono.Text = PersonaEntity.Telefono.ToString();
            cboBoxPlan.SelectedValue = PersonaEntity.PlanDescripcion;
            dtpFechaNacimiento.Value = PersonaEntity.FechaNacimiento;
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
            switch (this.Modo)
            {
                case Modoform.Alta:
                    Persona persona = new Persona();
                    this.PersonaEntity = persona;
                    this.PersonaEntity.State = BusinessEntity.States.New;
                    break;
                case Modoform.Modificacion:
                    this.PersonaEntity.State = BusinessEntity.States.Modified;
                    break;
                case Modoform.Baja:
                    this.PersonaEntity.State = BusinessEntity.States.Deleted;
                    break;

            }

            if (this.Modo == Modoform.Alta || Modo == Modoform.Modificacion)
            {

                PersonaEntity.Apellido = this.txtBoxApellido.Text;
                PersonaEntity.Nombre = this.txtBoxNombre.Text;
                PersonaEntity.Telefono = this.txtBoxTelefono.Text;
                PersonaEntity.Direccion = this.txtBoxDireccion.Text;
                PersonaEntity.Plan = new Plan();
                int itemSeleccionadoPlan = cboBoxPlan.SelectedIndex;
                PersonaEntity.Plan.ID = this.listaPlanes[itemSeleccionadoPlan].ID;
                PersonaEntity.TipoPersona = Persona.TipoPersonas.Docente;




            }



        }

        public override bool Validar()
        {
            if (this.cboBoxPlan.SelectedValue == null || this.dtpFechaNacimiento.Value ==null || !Util.Validar.Email_valido(this.txtBoxEmail.Text) || string.IsNullOrEmpty(this.txtBoxTelefono.Text) || string.IsNullOrEmpty(this.txtBoxNombre.Text) || string.IsNullOrEmpty(this.txtBoxLegajo.Text) || string.IsNullOrEmpty(this.txtBoxDireccion.Text) || string.IsNullOrEmpty(this.txtBoxApellido.Text))
            {
                this.Notificar("INFORMACION INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;

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


        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                PersonaLogic personaLogic = new PersonaLogic();
                personaLogic.Save(this.PersonaEntity);
                this.Notificar("GUARDADO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void Eliminar()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este docente?.", "Eliminar Docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                PersonaLogic personaLogic = new PersonaLogic();
                personaLogic.Delete(this.PersonaEntity.ID);
                this.Close();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
