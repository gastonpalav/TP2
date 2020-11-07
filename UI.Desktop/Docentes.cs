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
            InitializeComponent();
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.AutoGenerateColumns = false;
            this.dgvDocentes.MultiSelect = false;
            
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
            DocentesDesktop docentesDesktop = new DocentesDesktop(ApplicationForm.Modoform.Alta);
            docentesDesktop.ShowDialog();
            Listar();
            
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if ((dgvDocentes.SelectedRows.Count > 0))
            {
                int ID = ((Persona)this.dgvDocentes.SelectedRows[0].DataBoundItem).ID;
                DocentesDesktop docenteDesktop = new DocentesDesktop(ID, ApplicationForm.Modoform.Modificacion);
                docenteDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if ((dgvDocentes.SelectedRows.Count > 0))
            {
                int ID = ((Persona)this.dgvDocentes.SelectedRows[0].DataBoundItem).ID;
                DocentesDesktop docenteDesktop = new DocentesDesktop(ID, ApplicationForm.Modoform.Baja);
                docenteDesktop.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}