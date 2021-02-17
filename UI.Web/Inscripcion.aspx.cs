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
        public Persona PersonaEntity { get; set; }
        public AlumnoInscripcion AlumnoInscripcionEntity { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonaEntity = (Persona)Session["USUARIO"];

            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
            if (this.gridView.Rows.Count > 0)
            {
                this.gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
            }

        }

        private CursoLogic _logic;
        public CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            PlanLogic plan = new PlanLogic();

            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();

        }

        protected void inscribirLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void cancelarLinkButtom_Click(object sender, EventArgs e)
        {

        }
    }
}