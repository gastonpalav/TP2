using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
            this.dgvComisiones.MultiSelect = false;

        }

        public void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            this.dgvComisiones.DataSource = cl.GetAll();
        }

        private void tscComisiones_Click(object sender, System.EventArgs e)
        {

        }

        private void Comisiones_Load(object sender, System.EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, System.EventArgs e)
        {
            ComisionDesktop comisionDesktop = new ComisionDesktop(ApplicationForm.Modoform.Alta);
            comisionDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, System.EventArgs e)
        {
            if ((dgvComisiones.SelectedRows.Count > 0))
            {
                int ID = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionDesktop comisionDesktop = new ComisionDesktop(ID, ApplicationForm.Modoform.Modificacion);
                comisionDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void tsbEliminar_Click(object sender, System.EventArgs e)
        {
            if ((dgvComisiones.SelectedRows.Count > 0))
            {
                int ID = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionDesktop comisionDesktop = new ComisionDesktop(ID, ApplicationForm.Modoform.Baja);
                comisionDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }
    }
}
