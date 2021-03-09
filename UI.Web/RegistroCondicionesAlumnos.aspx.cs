using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class RegistroCondicionesAlumnos : System.Web.UI.Page
    {
        private DocentesCursosLogic _logicDC;
        private AlumnoInscripcionLogic _logicAI;


        


        private DocenteCurso Entity { get; set; }
        public Persona usuDocente { set; get; }
        private enum Condiciones
        {
            Libre,
            Regular,
            Aprobado
        };

        public AlumnoInscripcionLogic LogicAlumnoInscripcion
        {

            get
            {
                if (_logicAI == null)
                {
                    _logicAI = new AlumnoInscripcionLogic();
                }
                return _logicAI;
            }
        }
        public DocentesCursosLogic LogicDocenteCursos
        {
            get
            {
                if (_logicDC == null)
                {
                    _logicDC = new DocentesCursosLogic();
                }
                return _logicDC;
            }
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.usuDocente = (Persona)Session["USUARIO"];
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
            if (this.gridView.Rows.Count > 0)
            {
                this.gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        private void LoadGrid()
        {
           

            this.gridView.DataSource = this.LogicDocenteCursos.GetAllByDocente(usuDocente);
            this.gridView.DataBind();

            if (this.CondicionDropDown.Items.Count == 1)
            {
                this.CondicionDropDown.DataSource = Enum.GetValues(typeof(Condiciones));
              
                this.CondicionDropDown.DataBind();
            }

        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        

       

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int ID)
        {

            this.Entity = this.LogicDocenteCursos.GetOne(ID);
            this.LegajoTextBox.Text = this.Entity.LegajoAlumno.ToString();
            this.MateriaTextBox.Text = this.Entity.CursoDescripcion.ToString();
            this.NotaTextBox.Text = this.Entity.AlumnoNota.ToString();
            this.CargoTextBox.Text = this.Entity.Cargo.ToString();
            this.CondicionDropDown.SelectedValue = this.Entity.AlumnoCondicion;
        }


        private void LoadEntity(DocenteCurso dc)
        {

            dc.AlumnoInscripcion = new AlumnoInscripcion();
            dc.AlumnoInscripcion.ID = LogicDocenteCursos.GetOne(dc.ID).AlumnoInscripcionID;
            dc.AlumnoInscripcion.Nota = int.Parse(NotaTextBox.Text);
            dc.AlumnoInscripcion.Condicion = CondicionDropDown.SelectedValue.ToString();
              
                

            
        }
        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            this.Entity = new DocenteCurso();
            this.Entity.ID = this.SelectedID;
            this.Entity.State = BusinessEntity.States.Modified;
            this.LoadEntity(this.Entity);
            this.SaveEntity(this.Entity);
            this.LoadGrid();
            
        }
        protected void cancelarLinkButtom_Click(object sender, EventArgs e)
        {
            //Probando limpiar seleccion
            this.gridView.SelectedIndex = -1;
            this.SelectedID = 0;
        }

        private void EnableForm(bool enable)
        {
            this.CargoTextBox.Enabled = enable;
            this.LegajoTextBox.Enabled = enable;
            this.MateriaTextBox.Enabled = enable;
            this.NotaTextBox.Enabled = enable;
            this.CondicionDropDown.Enabled = enable;
            this.LegajoTextBox.ReadOnly = true;
            this.MateriaTextBox.ReadOnly = true;
            this.CargoTextBox.ReadOnly = true;
           
        }

        protected void editarlinkButton_Click(object sender, EventArgs e)
        {


            if (this.IsEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.formActionPanel.Visible = true;

                this.LoadForm(this.SelectedID);
            }

        }

        private void SaveEntity(DocenteCurso docenteCurso)
        {
           
           
            try

            {

               AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion();
                alumnoInscripcion.Nota = docenteCurso.AlumnoNota;
                alumnoInscripcion.Condicion = docenteCurso.AlumnoCondicion;
                alumnoInscripcion.ID = docenteCurso.AlumnoInscripcionID;
                alumnoInscripcion.State = BusinessEntity.States.Modified;
                LogicAlumnoInscripcion.Update(alumnoInscripcion);
                //testing  ScriptManager
                string script = "alert(\"Condicion actualizada\");";
                ScriptManager.RegisterStartupScript(this, GetType(),"ServerControlScript", script, true);
              
            }



            catch (Exception ex)
            {

             throw ex;
            }
        }

        
    }
}