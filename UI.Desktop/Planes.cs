using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dvgPlanes.AutoGenerateColumns = false;
            this.dvgPlanes.MultiSelect = false;
        }

        public void Listar()
        {
            try
            {
                PlanLogic PL = new PlanLogic();
                this.dvgPlanes.DataSource = PL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los datos del plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop planDesktop = new PlanDesktop(ApplicationForm.Modoform.Alta);
            planDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dvgPlanes.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Plan)this.dvgPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop planDesktop = new PlanDesktop(ID, ApplicationForm.Modoform.Modificacion);
                planDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro");
            }
        }

        private void tsbElminar_Click(object sender, EventArgs e)
        {
            if(dvgPlanes.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Plan)this.dvgPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop planDesktop = new PlanDesktop(ID, ApplicationForm.Modoform.Baja);
                planDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro");
            }
        }
    }
}
