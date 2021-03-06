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
    public partial class RegistroCondicionesAlumnos : Form
    {
        public Persona usuDocente { set; get; }
       
        public RegistroCondicionesAlumnos(Persona docente)
        {
            InitializeComponent();

            this.usuDocente = docente;
            this.dgvRegistroAlumnos.ReadOnly = true;
            this.dgvRegistroAlumnos.AutoGenerateColumns = false;
            this.dgvRegistroAlumnos.MultiSelect = false;
        }

        private void tsb_Editar_Click(object sender, EventArgs e)
        {
            if ((dgvRegistroAlumnos.SelectedRows.Count > 0))
            {
                //int ID = ((DocenteCurso)this.dgvRegistroAlumnos.SelectedRows[0].DataBoundItem).ID;
                RegistroCondicionesAlumnosDesktop RegistroCondicionesAlumnosDesktop = new RegistroCondicionesAlumnosDesktop(ID, ApplicationForm.Modoform.Modificacion);
                RegistroCondicionesAlumnosDesktop.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONAR UN REGISTRO");
            }
        }

        private void RegistroCondicionesAlumnos_Load(object sender, EventArgs e)
        {

            Listar();
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }


        private void Listar()
        {
            try
            {
                DocenteCursosLogic docenteCursoLogic = new DocenteCursosLogic();
                docenteCursoLogic.GetAllByDocente(usuDocente);
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}
