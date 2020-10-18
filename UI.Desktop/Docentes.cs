using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Docentes : Form
    {
        public Docentes()
        {
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.AutoGenerateColumns = false;
            this.dgvDocentes.MultiSelect = false;
            InitializeComponent();
        }

        private void Docentes_Load(object sender, System.EventArgs e)
        {
            this.Listar();
        }

        private void Listar()
        {
            try
            {
                PersonaLogic personaLogic = new PersonaLogic();
                this.dgvDocentes.DataSource = personaLogic.GetAllPersonasByType(Persona.TipoPersonas.Docente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los datos de los docentes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}