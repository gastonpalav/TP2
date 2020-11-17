using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;


namespace UI.Web
{
    public partial class DatosPersonalesAlumno : System.Web.UI.Page
    {
        private PersonaLogic _logic;
        public PersonaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonaLogic();
                }
                return _logic;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Entity = (Persona)Session["USUARIO"];
            PlanLogic plan = new PlanLogic();
            if (this.planDropDown.Items.Count == 1)
            {
                this.planDropDown.DataSource = plan.GetAll();
                this.planDropDown.DataTextField = "Descripcion";
                this.planDropDown.DataValueField = "ID";
                this.planDropDown.DataBind();
            }
            LoadForm(Entity.ID);
            EnableForm(false);
        }

        public Persona Entity { get; set; }
        public enum FormModes
        {
            consulta,
            modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        
        private void LoadForm(int ID)
        {
            
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.Email;
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.fechaNacimientoTextBox.Text = this.Entity.FechaNacimiento.ToShortDateString();
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.planDropDown.SelectedValue= this.Entity.Plan.ID.ToString();

        }

        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.direccionTextBox.Enabled = enable;
            this.telefonoTextBox.Enabled = enable;
            this.fechaNacimientoTextBox.Enabled = enable;
            this.legajoTextBox.Enabled = enable;
            this.planDropDown.Enabled = enable;

         

        }





        private void LoadEntity(Persona persona)
        {
            persona.Nombre = this.nombreTextBox.Text;
            persona.Apellido = this.apellidoTextBox.Text;
            persona.Email = this.emailTextBox.Text;
            persona.Direccion = this.direccionTextBox.Text;
            persona.TipoPersona = Persona.TipoPersonas.Alumno;
            persona.Legajo = int.Parse(this.legajoTextBox.Text);
            persona.FechaNacimiento = DateTime.Parse(this.fechaNacimientoTextBox.Text);
            persona.Telefono = this.telefonoTextBox.Text;
            persona.Plan = new Plan();
            persona.Plan.ID = int.Parse(this.planDropDown.SelectedItem.Value);


        }




        private void SaveEntity(Persona persona)
        {
            this.Logic.Save(persona);
        }


        protected void editarlinkButton_Click(object sender, EventArgs e)
        {
            
            
                this.EnableForm(true);
                this.FormMode = FormModes.modificacion;
                this.LoadForm(Entity.ID);
            
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.consulta:
                    break;
                case FormModes.modificacion:
                    this.Entity = new Persona();
                    this.Entity.ID = Entity.ID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
                
                  
            }
            
        }

        protected void cancelarLinkButtom_Click(object sender, EventArgs e)
        {
            LoadForm(Entity.ID);
            EnableForm(false);
        }
    }
}