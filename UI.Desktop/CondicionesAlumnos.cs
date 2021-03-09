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
    public partial class CondicionesAlumnos : ApplicationForm
    {
        public Persona usuDocente { set; get; }

        public CondicionesAlumnos(Modoform modo) : this()
        {
            this.Modo = modo;
            
        }

        public CondicionesAlumnos(Persona docente, Modoform modo) : this()
        {
            this.Modo = modo;
            this.usuDocente = docente;
            this.dgvRegistroAlumnos.ReadOnly = true;
            this.dgvRegistroAlumnos.AutoGenerateColumns = false;
            this.dgvRegistroAlumnos.MultiSelect = false;
        }

        public CondicionesAlumnos()
        {
            InitializeComponent();
            



        }

        private void tsb_Editar_Click(object sender, EventArgs e)
        {
            if ((dgvRegistroAlumnos.SelectedRows.Count > 0))
            {
                int ID = ((DocenteCurso)this.dgvRegistroAlumnos.SelectedRows[0].DataBoundItem).ID;
                if (Modo == ApplicationForm.Modoform.Consulta)
                {
                    CondicionesAlumnosDesktop RegistroCondicionesAlumnosDesktop = new CondicionesAlumnosDesktop(ID, ApplicationForm.Modoform.Consulta);
                    RegistroCondicionesAlumnosDesktop.ShowDialog();
                }
                if (Modo == ApplicationForm.Modoform.Modificacion)
                {
                    CondicionesAlumnosDesktop RegistroCondicionesAlumnosDesktop = new CondicionesAlumnosDesktop(ID, ApplicationForm.Modoform.Modificacion);
                    RegistroCondicionesAlumnosDesktop.ShowDialog();
                }

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
                DocentesCursosLogic docenteCursoLogic = new DocentesCursosLogic();
                dgvRegistroAlumnos.DataSource=docenteCursoLogic.GetAllByDocente(usuDocente);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

