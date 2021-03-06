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
    /// <summary>
    /// FALTA
    /// </summary>
    public partial class RegistroCondicionesAlumnosDesktop : ApplicationForm
    {
        public RegistroCondicionesAlumnosDesktop()
        {
            InitializeComponent();
        }

        public RegistroCondicionesAlumnosDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public Persona PersonaEntity { get; set; }

        public RegistroCondicionesAlumnosDesktop(int ID, Modoform modo) : this()
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
            //txtBoxCurso.Text = PersonaEntity.Direccion.ToString();
            //txtBoxCondicion.Text = PersonaEntity.Email.ToString();
            txtBoxLegajo.Text = PersonaEntity.Legajo.ToString();
            txtBoxNombre.Text = PersonaEntity.Nombre.ToString();
            this.btnAceptar.Text = "Guardar";
                  
               

            
        }


        public override void MapearADatos()
        {

            this.PersonaEntity.State = BusinessEntity.States.Modified;
            PersonaEntity.Apellido = this.txtBoxApellido.Text;
            PersonaEntity.Nombre = this.txtBoxNombre.Text;
            //PersonaEntity.Plan = new Plan();
            //int itemSeleccionadoPlan = cboBoxPlan.SelectedIndex;
            //PersonaEntity.Plan.ID = this.listaPlanes[itemSeleccionadoPlan].ID;
            //PersonaEntity.TipoPersona = Persona.TipoPersonas.Alumno;




         }

        public override bool Validar()
        {
            if (this.cboBoxPlan.SelectedValue == null || this.dtpFechaNacimiento.Value == null || !Util.Validar.Email_valido(this.txtBoxEmail.Text) || string.IsNullOrEmpty(this.txtBoxTelefono.Text) || string.IsNullOrEmpty(this.txtBoxNombre.Text) || string.IsNullOrEmpty(this.txtBoxLegajo.Text) || string.IsNullOrEmpty(this.txtBoxDireccion.Text) || string.IsNullOrEmpty(this.txtBoxApellido.Text))
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
                PersonaLogic personaLogic = new PersonaLogic();
                personaLogic.Save(this.PersonaEntity);
                this.Notificar("GUARDADO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }
    }
}
