using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ReporteCursos : Form
    {
        private CursoLogic cursoLogic;

        public ReporteCursos()
        {
            InitializeComponent();

            this.cursoLogic = new CursoLogic();
        }

        private void ReporteCursos_Load(object sender, EventArgs e)
        {
            this.CursoBindingSource.DataSource = this.cursoLogic.GetAll();

            this.reportViewer1.RefreshReport();
        }
    }
}