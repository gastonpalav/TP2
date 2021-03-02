using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class EstadoAcademico : Form
    {
        public Persona usuAlumno { set; get; }
        public EstadoAcademico()
        {
            InitializeComponent();
            this.dgvEstadoAcademico.ReadOnly = true;
            this.dgvEstadoAcademico.AutoGenerateColumns = false;
            this.dgvEstadoAcademico.MultiSelect = false;
        }

        public EstadoAcademico(Persona persona)
        {
            InitializeComponent();
            this.dgvEstadoAcademico.ReadOnly = true;
            this.dgvEstadoAcademico.AutoGenerateColumns = false;
            this.dgvEstadoAcademico.MultiSelect = false;
            usuAlumno = persona;

        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        
        }

        private void EstadoAcademico_Load(object sender, EventArgs e)
        {
            Listar();
        }


        private void Listar()
        {
          try
           {
                AlumnoInscripcionLogic Logic = new AlumnoInscripcionLogic();
                this.dgvEstadoAcademico.DataSource = Logic.GetAllByAlumno(usuAlumno);
           }
           catch (Exception ex)
            {
               MessageBox.Show("Error al recuperar los datos de los Alumnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              throw ex;
          }
        }
    }
}
