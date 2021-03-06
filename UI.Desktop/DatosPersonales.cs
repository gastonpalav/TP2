﻿using System;
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
    public partial class DatosPersonales : ApplicationForm
    {

        private List<Plan> listaPlanes;
        public DatosPersonales()
        {
            InitializeComponent();
            PlanLogic planLogic = new PlanLogic();
            listaPlanes = planLogic.GetAll();
            this.cboBoxPlan.DataSource = listaPlanes;
            this.cboBoxPlan.ValueMember = "Descripcion";
            this.cboBoxPlan.DisplayMember = "Descripcion";
        }


        public DatosPersonales(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public Persona PersonaEntity { get; set; }

        public DatosPersonales(int ID, Modoform modo) : this()
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
            // Set the MinDate and MaxDate.
            dtpFechaNacimiento.MinDate = new DateTime(1900,01, 01);
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            dtpFechaNacimiento.Value = PersonaEntity.FechaNacimiento;
            switch (this.Modo)
            {
                case Modoform.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case Modoform.Consulta:
                    txtBoxID.Enabled = false;
                    txtBoxApellido.Enabled = false;
                    txtBoxDireccion.Enabled = false;
                    txtBoxEmail.Enabled = false;
                    txtBoxLegajo.Enabled = false;
                    txtBoxNombre.Enabled = false;
                    txtBoxTelefono.Enabled = false;
                    cboBoxPlan.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    this.btnAceptar.Text = "Aceptar";
                    break;

            }



        }



        public override void MapearADatos()
        {
            switch (this.Modo)
            {
                case Modoform.Consulta:
                    break;
                case Modoform.Modificacion:
                    this.PersonaEntity.State = BusinessEntity.States.Modified;
                    break;
               

            }

            if (Modo == Modoform.Modificacion)
            {

                PersonaEntity.Apellido = this.txtBoxApellido.Text;
                PersonaEntity.Nombre = this.txtBoxNombre.Text;
                PersonaEntity.Email = this.txtBoxEmail.Text;
                PersonaEntity.Telefono = this.txtBoxTelefono.Text;
                PersonaEntity.FechaNacimiento = this.dtpFechaNacimiento.Value;
                PersonaEntity.Direccion = this.txtBoxDireccion.Text;
                PersonaEntity.Plan = new Plan();
                int itemSeleccionadoPlan = cboBoxPlan.SelectedIndex;
                PersonaEntity.Plan.ID = this.listaPlanes[itemSeleccionadoPlan].ID;
                //PersonaEntity.TipoPersona = Persona.TipoPersonas.Alumno;




            }


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


            if (this.Modo == Modoform.Modificacion)
            {
                this.GuardarCambios();
            }
           


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

