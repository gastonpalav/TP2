﻿using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Alumnos : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
            if (this.gridView.Rows.Count > 0)
            {
                this.gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }

        private void LoadGrid()
        {
            PlanLogic plan = new PlanLogic();

            this.gridView.DataSource = this.Logic.GetAllPersonasByType(Persona.TipoPersonas.Alumno);
            this.gridView.DataBind();

            if (this.planDropDown.Items.Count == 1)
            {
                this.planDropDown.DataSource = plan.GetAll();
                this.planDropDown.DataTextField = "Descripcion";
                this.planDropDown.DataValueField = "ID";
                this.planDropDown.DataBind();
            }

        }
        public enum FormModes
        {
            alta,
            baja,
            modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Persona Entity { get; set; }
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int ID)
        {
            this.Entity = this.Logic.GetOneById(ID);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.Email;
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.fechaNacimientoTextBox.Text = this.Entity.FechaNacimiento.ToShortDateString();
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.planDropDown.SelectedValue = this.Entity.Plan.ID.ToString();

        }


        protected void editarlinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.formActionPanel.Visible = true;
                this.FormMode = FormModes.modificacion;
                this.LoadForm(this.SelectedID);
            }
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

        private void DeleteEntity(int ID)
        {
            try
            {
                this.Logic.Delete(ID);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError("", ex.Message);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.formActionPanel.Visible = true;
                this.FormMode = FormModes.baja;
                this.formActionPanel.Visible = true;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.formActionPanel.Visible = true;
            this.FormMode = FormModes.alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            this.legajoTextBox.Text = string.Empty;
            this.fechaNacimientoTextBox.Text = string.Empty;
            this.planDropDown.SelectedIndex = 0;
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.modificacion:
                    this.Entity = new Persona();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.alta:
                    this.Entity = new Persona();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
            this.formActionPanel.Visible = false;
            this.gridView.SelectedIndex = -1;
            this.SelectedID = 0;
        }

        protected void cancelarLinkButtom_Click(object sender, EventArgs e)
        {
            this.formActionPanel.Visible = false;
            this.formPanel.Visible = false;
            this.gridView.SelectedIndex = -1;
            this.SelectedID = 0;
        }
    }
}