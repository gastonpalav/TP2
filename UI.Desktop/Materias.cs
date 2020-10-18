using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.MultiSelect = false;
        }

        public void Listar()
        {
            try
            {
                MateriaLogic ml = new MateriaLogic();
                this.dgvMaterias.DataSource = ml.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar datos de la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void Materias_Load(object sender, EventArgs e)
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
            MateriaDesktop materiaDesktop = new MateriaDesktop(ApplicationForm.Modoform.Alta);
            materiaDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop materiaDesktop = new MateriaDesktop(ID, ApplicationForm.Modoform.Modificacion);
                materiaDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro");
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop materiaDesktop = new MateriaDesktop(ID, ApplicationForm.Modoform.Baja);
                materiaDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro");
            }
        }
    }
}
