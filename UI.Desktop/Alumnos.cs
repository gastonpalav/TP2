using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.MultiSelect = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            Listar();
        }




        private void Listar()
        {
            try
            {
                PersonaLogic personaLogic = new PersonaLogic();
                this.dgvAlumnos.DataSource = personaLogic.GetAllPersonasByType(Persona.TipoPersonas.Alumno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los datos de los Alumnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            AlumnosDesktop alumnosDesktop = new AlumnosDesktop(ApplicationForm.Modoform.Alta);
            alumnosDesktop.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if ((dgvAlumnos.SelectedRows.Count > 0))
            {
                int ID = ((Persona)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
                AlumnosDesktop alumnoDesktop = new AlumnosDesktop(ID, ApplicationForm.Modoform.Modificacion);
                alumnoDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void tstEliminar_Click(object sender, EventArgs e)
        {
            if ((dgvAlumnos.SelectedRows.Count > 0))
            {
                int ID = ((Persona)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
                AlumnosDesktop alumnoDesktop = new AlumnosDesktop(ID, ApplicationForm.Modoform.Baja);
                alumnoDesktop.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }
    }

}
