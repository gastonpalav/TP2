using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class SubirNota : Form
    {
        public SubirNota()
        {
            InitializeComponent();

            this.dgvNotas.AutoGenerateColumns = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubirNota_Click(object sender, EventArgs e)
        {
        }
    }
}