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
    public partial class EstadoAcademico : System.Web.UI.Page
    {

        public Persona usuAlumno { set; get; }
        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.usuAlumno = (Persona)Session["USUARIO"];
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


            this.gridView.DataSource = this.AlumnoInscripcionLogic.GetAllByAlumno(usuAlumno);
            this.gridView.DataBind();

        }
    }
}