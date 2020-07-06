using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.MultiSelect = false;
        }

        public void Listar()
        {
            try
            {
                UsuarioLogic usuarioLogic = new UsuarioLogic();
                this.dgvUsuarios.DataSource = usuarioLogic.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los datos del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void Usuarios_Load(object sender, System.EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, System.EventArgs e)
        {
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ApplicationForm.Modoform.Alta);
            usuarioDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbModificar_Click(object sender, System.EventArgs e)
        {
            if ((dgvUsuarios.SelectedRows.Count > 0))
            {
                int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ID, ApplicationForm.Modoform.Modificacion);
                usuarioDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void tsbEliminar_Click(object sender, System.EventArgs e)
        {
            if ((dgvUsuarios.SelectedRows.Count > 0))
            {
                int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ID, ApplicationForm.Modoform.Baja);
                usuarioDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }
    }
}