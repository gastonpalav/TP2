
namespace UI.Desktop
{
    partial class ReporteAlumnosPorComisiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpteAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.AlumnoInscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMateria = new System.Windows.Forms.Label();
            this.Comision = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoInscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpteAlumnos
            // 
            reportDataSource1.Name = "InscripcionesAlumnos";
            reportDataSource1.Value = this.AlumnoInscripcionBindingSource;
            this.rpteAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpteAlumnos.LocalReport.ReportEmbeddedResource = "UI.Desktop.AlumnoCursosInscriptos.rdlc";
            this.rpteAlumnos.Location = new System.Drawing.Point(1, 70);
            this.rpteAlumnos.Name = "rpteAlumnos";
            this.rpteAlumnos.ServerReport.BearerToken = null;
            this.rpteAlumnos.Size = new System.Drawing.Size(699, 338);
            this.rpteAlumnos.TabIndex = 0;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(92, 7);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(202, 21);
            this.cboMateria.TabIndex = 1;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // AlumnoInscripcionBindingSource
            // 
            this.AlumnoInscripcionBindingSource.DataSource = typeof(Business.Entities.AlumnoInscripcion);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(21, 10);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia";
            // 
            // Comision
            // 
            this.Comision.AutoSize = true;
            this.Comision.Location = new System.Drawing.Point(21, 43);
            this.Comision.Name = "Comision";
            this.Comision.Size = new System.Drawing.Size(49, 13);
            this.Comision.TabIndex = 3;
            this.Comision.Text = "Comisión";
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(92, 43);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(202, 21);
            this.cboComision.TabIndex = 4;
            this.cboComision.SelectedIndexChanged += new System.EventHandler(this.cboComision_SelectedIndexChanged);
            // 
            // ReporteAlumnosPorComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 407);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.Comision);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.rpteAlumnos);
            this.Name = "ReporteAlumnosPorComisiones";
            this.Text = "ReporteAlumnosPorComisiones";
            this.Load += new System.EventHandler(this.ReporteAlumnosPorComisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoInscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpteAlumnos;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.BindingSource AlumnoInscripcionBindingSource;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label Comision;
        private System.Windows.Forms.ComboBox cboComision;
    }
}