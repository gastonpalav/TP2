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
    public partial class Comisiones : System.Web.UI.Page
    {
        private ComisionLogic _logic;
        public Comision Entity { get; set; }
        private List<Plan> listaPlanes;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }

        }

        private void LoadGrid()
        {
            PlanLogic plan = new PlanLogic();
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
            if (this.planDropDown.Items.Count == 1)
            {
                this.planDropDown.DataSource = plan.GetAll();
                this.planDropDown.DataTextField = "Descripcion";
                this.planDropDown.DataValueField = "ID";
                this.planDropDown.DataBind();
            }

        }

        public ComisionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ComisionLogic();
                }
                return _logic;
            }
        }

        public enum FormModes
        {
            alta,
            baja,
            modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
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


        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }


        private void LoadForm(int ID)
        {
            this.Entity = this.Logic.GetOne(ID);
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.anioEspecialidadTextBox.Text = this.Entity.AnioEspecialidad.ToString();
            this.planDropDown.SelectedValue = this.Entity.Plan.ID.ToString();

        }

        protected void editarlinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.formActionPanel.Visible = true;
                this.FormMode = FormModes.modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        private void EnableForm(bool enable)
        {
            this.descripcionTextBox.Enabled = enable;
            this.anioEspecialidadTextBox.Enabled = enable;
            this.planDropDown.Enabled = enable;
            //int i = 0;
            //foreach (var item in listaPlanes)
            //{
            //    planDropDown.Items.Insert(i, new ListItem(item.Descripcion));
            //    i++;
            //}
        }
        private void LoadEntity(Comision comision)
        {
            comision.Descripcion = this.descripcionTextBox.Text;
            comision.AnioEspecialidad = int.Parse(this.anioEspecialidadTextBox.Text);
            comision.Plan = new Plan();
            int itemSeleccionadoPlan = planDropDown.SelectedIndex;
            comision.Plan.ID = this.listaPlanes[itemSeleccionadoPlan].ID;


        }
        private void SaveEntity(Comision comision)
        {
            this.Logic.Save(comision);
        }

        private void DeleteEntity(int ID)
        {
            this.Logic.Delete(ID);

        }
        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.baja;
                this.formActionPanel.Visible = true;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.formActionPanel.Visible = true;
            this.FormMode = FormModes.alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;
            this.anioEspecialidadTextBox.Text = string.Empty;
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.modificacion:
                    this.Entity = new Comision();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.alta:
                    this.Entity = new Comision();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
        
        }

        protected void cancelarLinkButtom_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
        }
    }
}