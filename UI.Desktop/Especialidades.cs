using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.dgvEspecialidades.MultiSelect = false;
        }

        public void Listar()
        {
            try
            {
                EspecialidadLogic especialidadLogic = new EspecialidadLogic();
                this.dgvEspecialidades.DataSource = especialidadLogic.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los datos del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void Especialidades_Load(object sender, EventArgs e)
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

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop usuarioDesktop = new EspecialidadDesktop(ApplicationForm.Modoform.Alta);
            usuarioDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if ((dgvEspecialidades.SelectedRows.Count > 0))
            {
                int ID = ((Business.Entities.Usuario)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(ID, ApplicationForm.Modoform.Modificacion);
                especialidadDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }
    }
}