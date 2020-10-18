using System;
using System.Collections.Generic;
using Business.Entities;
using Business.Logic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        private List<Plan> listaPlanes;

        public MateriaDesktop()
        {
            InitializeComponent();

            PlanLogic plan = new PlanLogic();
            listaPlanes = plan.GetAll();
            this.cboPlan.DataSource = listaPlanes;
            this.cboPlan.ValueMember = "Descripcion";
            this.cboPlan.DisplayMember = "Descripcion";
        }

        public MateriaDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public MateriaDesktop(int ID, Modoform modo) : this()
        {
            this.Modo = modo;
            MateriaLogic ml = new MateriaLogic();
            this.MateriaActual = ml.GetOne(ID);
            this.MapearDeDatos();
        }

        private Materia _materiaActual;

        public Materia MateriaActual
        {
            get { return _materiaActual; }
            set { _materiaActual = value; }
        }

        public override void MapearADatos()
        {
            switch (this.Modo)
            {
                case Modoform.Alta:
                    Materia materia = new Materia();

                    this.MateriaActual = materia;
                    this.MateriaActual.State = BusinessEntity.States.New;
                    break;

                case Modoform.Baja:
                    this.MateriaActual.State = BusinessEntity.States.Deleted;
                    break;

                case Modoform.Modificacion:
                    this.MateriaActual.State = BusinessEntity.States.Modified;
                    break;
            };

            if (this.Modo == Modoform.Alta || this.Modo == Modoform.Modificacion)
            {
                MateriaActual.Descripcion = this.txtDesc.Text;
                MateriaActual.HSSemanales = int.Parse(this.txtHsSem.Text);
                MateriaActual.HSTotales = int.Parse(this.txtHsTot.Text);

                MateriaActual.Plan = new Plan();

                int itemseleccionado = cboPlan.SelectedIndex;
                MateriaActual.Plan.ID = this.listaPlanes[itemseleccionado].ID;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDesc.Text = this.MateriaActual.Descripcion;
            this.txtHsSem.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHsTot.Text = this.MateriaActual.HSTotales.ToString();
            this.cboPlan.SelectedValue = this.MateriaActual.PlanDescripcion;

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
                MateriaLogic ml = new MateriaLogic();
                ml.Save(this.MateriaActual);
                this.Notificar("Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        public override bool Validar()
        {
            int falso = 0;

            if (string.IsNullOrEmpty(this.txtDesc.Text) || string.IsNullOrEmpty(this.txtHsSem.Text) || string.IsNullOrEmpty(this.txtHsTot.Text))
            {
                this.Notificar("INFORMACION INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(this.txtHsSem.Text, out falso) || !int.TryParse(this.txtHsTot.Text, out falso))
            {
                this.Notificar("CANTIDAD DE HORAS INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta materia?", "Eliminar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MateriaLogic ml = new MateriaLogic();
                ml.Delete(this.MateriaActual.ID);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
