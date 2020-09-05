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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.MultiSelect = false;
        }

        public void Listar()
        {
            
            CursoLogic cl = new CursoLogic();
            this.dgvCursos.DataSource = cl.GetAll();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop cursoDesktop = new CursoDesktop(ApplicationForm.Modoform.Alta);
            cursoDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {

            if ((dgvCursos.SelectedRows.Count > 0))
            {
                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop cursoDesktop = new CursoDesktop(ID, ApplicationForm.Modoform.Modificacion);
                cursoDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void tsbEliminar_Click(object sender, System.EventArgs e)
        {
            if ((dgvCursos.SelectedRows.Count > 0))
            {
                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop cursoDesktop = new CursoDesktop(ID, ApplicationForm.Modoform.Baja);
                cursoDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }
    }
}
