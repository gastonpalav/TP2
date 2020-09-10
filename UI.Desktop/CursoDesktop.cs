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
    public partial class CursoDesktop : ApplicationForm
    {
        private List<Comision> listaComisiones;
        private List<Materia> listaMaterias;
        
        public CursoDesktop()
        {
            InitializeComponent();
            ComisionLogic Comision = new ComisionLogic();
            listaComisiones = Comision.GetAll();
            this.cboComision.DataSource = listaComisiones;
            this.cboComision.ValueMember = "Descripcion";
            this.cboComision.DisplayMember = "Descripcion";
            MateriaLogic Materia = new MateriaLogic();
            listaMaterias = Materia.GetAll();
            this.cboMateria.DataSource = listaMaterias;
            this.cboMateria.ValueMember = "Descripcion";
            this.cboMateria.DisplayMember = "Descripcion";



        }

        

        private void tlpCursos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private Business.Entities.Curso  _cursoActual;

        public Business.Entities.Curso CursoActual

        {
            get { return _cursoActual; }
            set { _cursoActual = value; }
        }

        public CursoDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
        }

        public CursoDesktop(int ID,Modoform modo) :this()
        {
            this.Modo= modo;
            CursoLogic cursoLogic = new CursoLogic();
            this.CursoActual=cursoLogic.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CursoActual.ID.ToString();
            this.txtAnioCalendario.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            this.cboComision.SelectedValue = this.CursoActual.ComisionDescripcion;
            this.cboMateria.SelectedValue = this.CursoActual.MateriaDescripcion;
            switch(this.Modo)
            {
                case Modoform.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case Modoform.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case Modoform.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;

            }



        }

        public override void MapearADatos()
        {
            switch(this.Modo)
            {
                case Modoform.Alta:
                    Business.Entities.Curso curso = new Business.Entities.Curso();
                    this.CursoActual = curso;
                    this.CursoActual.State = BusinessEntity.States.New;
                    break;
                case Modoform.Modificacion:
                    this.CursoActual.State = BusinessEntity.States.Modified;
                    break;
                case Modoform.Baja:
                    this.CursoActual.State = BusinessEntity.States.Deleted;
                    break;

            }

            if (this.Modo == Modoform.Alta || Modo == Modoform.Modificacion)
            {
                
                CursoActual.AnioCalendario = Convert.ToInt32(this.txtAnioCalendario.Text);
                CursoActual.Cupo = Convert.ToInt32(this.txtCupo.Text);
                CursoActual.Materia = new Materia();
                int itemSeleccionadoMateria = cboMateria.SelectedIndex;
                CursoActual.Materia.ID = this.listaMaterias[itemSeleccionadoMateria].ID;
                CursoActual.Comision = new Business.Entities.Comision();
                int itemSeleccionadoComision = cboComision.SelectedIndex;
                CursoActual.Comision.ID = this.listaComisiones[itemSeleccionadoComision].ID;



            }

        }

        public override bool Validar()
        {
            if (this.cboComision.SelectedValue==null || this.cboMateria.SelectedValue==null || string.IsNullOrEmpty(this.txtAnioCalendario.Text) || string.IsNullOrEmpty(this.txtCupo.Text))
            {
                this.Notificar("INFORMACION INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
            
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                CursoLogic cursoLogic = new CursoLogic();
                cursoLogic.Save(this.CursoActual);
                this.Notificar("GUARDADO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo == Modoform.Alta || this.Modo == Modoform.Modificacion)
            {
                this.GuardarCambios();
            }
            else if (this.Modo == Modoform.Baja)
            {
                this.Eliminar();
            }
        }




        private void Eliminar()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este curso?.", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                CursoLogic cursoLogic = new CursoLogic();
                cursoLogic.Delete(this.CursoActual.ID);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdComision_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
