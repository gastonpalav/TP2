using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ReporteMaterias : Form
    {
        private MateriaLogic materiaLogic;

        public ReporteMaterias()
        {
            InitializeComponent();

            this.materiaLogic = new MateriaLogic();
        }

        private void ReporteMaterias_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            this.MateriaBindingSource.DataSource = materiaLogic.GetAll();
        }
    }
}