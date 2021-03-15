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
    public partial class ComisionDesktop : ApplicationForm
    {

        public List<Plan> listaPlanes;
        private Comision _comisionActual;   

        public Comision ComisionActual
        {
            get { return _comisionActual; }
            set { _comisionActual = value; }
        }


        public ComisionDesktop()
        {
            InitializeComponent();
            PlanLogic plan = new PlanLogic();
            listaPlanes = plan.GetAll();
            this.cboPlanDescripcion.DataSource = listaPlanes ;
            this.cboPlanDescripcion.ValueMember = "Descripcion";
            this.cboPlanDescripcion.DisplayMember = "Descripcion";
        }
        
        public ComisionDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public ComisionDesktop(int ID,Modoform modo) :this()
        {
            this.Modo = modo;
            ComisionLogic comisionLogic = new ComisionLogic();
            this.ComisionActual = comisionLogic.GetOne(ID);
            this.MapearDeDatos();

        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion.ToString();
            this.cboPlanDescripcion.SelectedValue = this.ComisionActual.PlanDescripcion;
            
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
                    Comision comision = new Comision();
                    this.ComisionActual = comision;
                    this.ComisionActual.State = BusinessEntity.States.New;
                    break;
                case Modoform.Modificacion:
                    this.ComisionActual.State = BusinessEntity.States.Modified;
                    break;
                case Modoform.Baja:
                    this.ComisionActual.State = BusinessEntity.States.Deleted;
                    break;

            }

            if (this.Modo == Modoform.Alta || Modo == Modoform.Modificacion)
            {

                ComisionActual.Descripcion = Convert.ToString(this.txtDescripcion.Text);
                ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);
                ComisionActual.Plan = new Plan();
                int itemSeleccionadoPlan = cboPlanDescripcion.SelectedIndex;
                ComisionActual.Plan.ID = this.listaPlanes[itemSeleccionadoPlan].ID;
            }

        }

        public override bool Validar()
        {
            if (this.cboPlanDescripcion.SelectedValue == null || string.IsNullOrEmpty(this.txtAnioEspecialidad.Text) || string.IsNullOrEmpty(this.txtDescripcion.Text))
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
                ComisionLogic comisionLogic = new ComisionLogic();
                comisionLogic.Save(this.ComisionActual);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Eliminar()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta comision?.", "Eliminar comision", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    ComisionLogic comisionLogic = new ComisionLogic();
                    comisionLogic.Delete(this.ComisionActual.ID);
                    this.Close();
                }
                catch (Exception ex)
                {
                    this.Notificar("ERROR", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

       

        
    }
}
