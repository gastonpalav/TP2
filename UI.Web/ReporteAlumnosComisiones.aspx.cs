using Business.Entities;
using Business.Logic;
using Microsoft.Reporting.WebForms;
using System;
using System.IO;

namespace UI.Web
{
    public partial class ReporteAlumnosComisiones : System.Web.UI.Page
    {
        private AlumnoInscripcionLogic logic;

        private Persona personaLogueada;

        public ReporteAlumnosComisiones()
        {
            this.logic = new AlumnoInscripcionLogic();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            personaLogueada = (Persona)Session["USUARIO"];
        }

        protected void GenerarReporte_Click(object sender, EventArgs e)
        {
            string deviceInfo = "";
            Warning[] warnings;
            string[] streamids;

            string mimeType = string.Empty;
            string encoding = string.Empty;
            string filenameExtension = string.Empty;

            ReportViewer viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = "AlumnoCursosInscriptos.rdlc";
            viewer.LocalReport.DataSources.Add(new ReportDataSource("InscripcionesAlumnos", this.logic.GetAllByAlumno(personaLogueada)));

            viewer.LocalReport.Refresh();

            var bytes = viewer.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            string fileNAme = @"E:\GastonP\Descargas";

            File.WriteAllBytes(fileNAme, bytes);

            System.Diagnostics.Process.Start(fileNAme);
        }
    }
}