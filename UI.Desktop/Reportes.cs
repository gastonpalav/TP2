using Business.Logic;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Reportes : Form
    {
        private string ReporteCursosFileName = "ReporteCursos.rdlc";

        private CursoLogic cursoLogic;

        public Reportes()
        {
            InitializeComponent();

            this.cursoLogic = new CursoLogic();
        }

        private void btnReporteCursos_Click(object sender, EventArgs e)
        {
            //ReportViewer report = new ReportViewer();

            //report.LocalReport.ReportEmbeddedResource = ReporteCursosFileName;

            //ReportDataSource reportDataSource = new ReportDataSource("Cursos", this.cursoLogic.GetAll());

            //report.LocalReport.DataSources.Clear();

            //report.LocalReport.DataSources.Add(reportDataSource);

           
        }
    }
}