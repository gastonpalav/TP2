using System;
using System.Collections.Generic;
using Business.Entities;
using Business.Logic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        public EspecialidadDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public EspecialidadDesktop(int ID, Modoform modo): this()
        {
            this.Modo = modo;
            EspecialidadLogic especialidadLogic = new EspecialidadLogic();
            this.EspecialidadActual = especialidadLogic.GetOne(ID);
            this.MapearDeDatos();
        }

        private Especialidad _especialidadActual;

        public Especialidad EspecialidadActual
        {
            get { return _especialidadActual; }
            set { _especialidadActual = value; }
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                EspecialidadLogic especialidadLogic = new EspecialidadLogic();
                especialidadLogic.Save(this.EspecialidadActual);
                this.Notificar("GUARDADO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion.ToString();
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
                    Especialidad especialidad = new Especialidad();

                    this.EspecialidadActual = especialidad;
                    this.EspecialidadActual.State = BusinessEntity.States.New;
                    break;

                case Modoform.Modificacion:
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                    break;

                case Modoform.Baja:
                    this.EspecialidadActual.State = BusinessEntity.States.Deleted;
                    break;
            }

            if (this.Modo == Modoform.Alta || Modo == Modoform.Modificacion)
            {
                this.EspecialidadActual.Descripcion = txtDescripcion.Text;
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                this.Notificar("INFORMACION INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; };
        }

        private void Eliminar()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta Especialidad?.", "Eliminar Especialidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    EspecialidadLogic especialidadLogic = new EspecialidadLogic();
                    especialidadLogic.Delete(this.EspecialidadActual.ID);
                    this.Close();
                }
                catch (Exception ex)
                {
                    this.Notificar("ERROR", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    } 
}