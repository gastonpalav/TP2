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
    public partial class Inscripcion : System.Web.UI.Page
    {
        //private List<Materia> listaMaterias;
        private List<Business.Entities.Curso> listaCursos;
        public Persona usuAlumno { set; get; }

        public AlumnoInscripcion alumnoInscripcion { get; set; }

        public Curso cursoAInscribir { get; set; }

        private MateriaLogic materiaLogic { get; set; }

        private ComisionLogic comisionLogic { get; set; }

        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set; }


        private CursoLogic _cursologic;
        public CursoLogic cursoLogic
        {
            get
            {
                if (_cursologic == null)
                {
                    _cursologic = new CursoLogic();
                }
                return _cursologic;
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
            this.usuAlumno = (Persona)Session["USUARIO"];
            this.materiaLogic = new MateriaLogic();
            this.comisionLogic = new ComisionLogic();
            listaCursos = cursoLogic.GetAll();
            this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();

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
            

            this.gridView.DataSource = this.cursoLogic.GetAll();
            this.gridView.DataBind();

        }

        protected void inscribirLinkButton_Click(object sender, EventArgs e)
        {

            this.Inscribir();
            

        }

        protected void cancelarLinkButtom_Click(object sender, EventArgs e)
        {
            //Probando limpiar seleccion
            this.gridView.SelectedIndex = -1;
            this.SelectedID = 0;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }


        private void Inscribir()
        {
            Business.Entities.Curso curso = cursoLogic.GetOne(SelectedID);
            try
            {

                if (curso.Cupo > 0)
                {

                    Business.Entities.AlumnoInscripcion alumnoIns = new Business.Entities.AlumnoInscripcion();
                    alumnoInscripcion = alumnoIns;
                    alumnoInscripcion.State = BusinessEntity.States.New;
                    foreach (var cursos in listaCursos)
                    {
                        if (curso.ID == cursos.ID)
                        {
                            alumnoInscripcion.IDCurso = cursos.ID;
                            alumnoInscripcion.IDAlumno = usuAlumno.ID;
                            if (AlumnoInscripcionLogic.Inscribir(alumnoInscripcion))
                            {
                                //testing  ScriptManager
                                string script = "alert(\"Inscripcion realizada\");";
                                ScriptManager.RegisterStartupScript(this, GetType(),
                                                      "ServerControlScript", script, true);
                            }
                            else
                            {
                                //testing  ScriptManager
                                string script = "alert(\"Error, ya se ha realizado la inscripcion a este curso\");";
                                ScriptManager.RegisterStartupScript(this, GetType(),
                                                      "ServerControlScript", script, true);
                            }



                        }
                    }
                }
            }


            catch (Exception ex)
            {
                
                throw ex ;
            }
        }
    }
}