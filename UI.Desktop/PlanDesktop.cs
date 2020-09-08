using Business.Entities;
using Business.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        private List<Especialidad> listaEspecialidades;
        public PlanDesktop()
        {
            InitializeComponent();
            EspecialidadLogic especialidad = new EspecialidadLogic();
            listaEspecialidades = especialidad.GetAll();
            this.cboEspecialidad.DataSource = listaEspecialidades;
            this.cboEspecialidad.DisplayMember = "Descripcion";
            
        }

        public PlanDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public PlanDesktop(int ID, Modoform modo) : this()
        {
            this.Modo = modo;
            PlanLogic planLogic = new PlanLogic();
            this.PlanActual = planLogic.GetOne(ID);
            this.MapearDeDatos();
        }

        private Plan _planActual;

        public Plan PlanActual
        {
            get { return _planActual; }
            set { _planActual = value; }
        }

        public override void MapearADatos()
        {
            switch (this.Modo)
            {
                case Modoform.Alta:
                    Plan plan = new Plan();

                    this.PlanActual = plan;
                    this.PlanActual.State = BusinessEntity.States.New;
                    break;

                case Modoform.Baja:
                    this.PlanActual.State = BusinessEntity.States.Deleted;
                    break;

                case Modoform.Modificacion:
                    this.PlanActual.State = BusinessEntity.States.Modified;
                    break;
            };

            if (this.Modo == Modoform.Alta || this.Modo == Modoform.Modificacion)
            {
                PlanActual.Descripcion = this.txtDesc.Text;
                PlanActual.Especialidad = new Especialidad();
                int itemseleccionado = cboEspecialidad.SelectedIndex;
                PlanActual.Especialidad.ID = this.listaEspecialidades[itemseleccionado].ID;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDesc.Text = this.PlanActual.Descripcion;
            this.cboEspecialidad.SelectedValue = this.PlanActual.EspecialidadDescripcion;

            switch (this.Modo)
            {
                case Modoform.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case Modoform.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case Modoform.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                PlanLogic planLogic = new PlanLogic();
                planLogic.Save(this.PlanActual);
                this.Notificar("Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(this.txtDesc.Text))
            {
                this.Notificar("INFORMACION INCOMPLETA, INGRESE DESCRIPCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
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
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este plan?", "Eliminar Plan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                PlanLogic planLogic = new PlanLogic();
                planLogic.Delete(this.PlanActual.ID);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
