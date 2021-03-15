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
    public partial class DocentesCursos : Form
    {
        public DocentesCursos()
        {
            InitializeComponent();
            this.dgvDocentesCursos.AutoGenerateColumns = false;
            this.dgvDocentesCursos.MultiSelect = false;
        }

        public void Listar()
        {
            
            DocentesCursosLogic dc = new DocentesCursosLogic();
            this.dgvDocentesCursos.DataSource = dc.GetAll();
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
            DocenteCursoDesktop docentecursoDesktop = new DocenteCursoDesktop(ApplicationForm.Modoform.Alta);
            docentecursoDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {

            if ((dgvDocentesCursos.SelectedRows.Count > 0))
            {
                int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocenteCursoDesktop docentecursoDesktop = new DocenteCursoDesktop(ID, ApplicationForm.Modoform.Modificacion);
                docentecursoDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void tsbEliminar_Click(object sender, System.EventArgs e)
        {
            if ((dgvDocentesCursos.SelectedRows.Count > 0))
            {
                int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocenteCursoDesktop docentecursoDesktop = new DocenteCursoDesktop(ID, ApplicationForm.Modoform.Baja);
                docentecursoDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }
    }
}
