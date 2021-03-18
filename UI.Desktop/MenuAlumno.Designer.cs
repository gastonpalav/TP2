namespace UI.Desktop
{
    partial class MenuAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAlumno));
            this.menuAlumnos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirseAUnaMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEstadoAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMateriasInscriptasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.datosPersonalesToolStripMenuItem,
            this.estadoAcademicoToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuAlumnos.Location = new System.Drawing.Point(0, 0);
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuAlumnos.Size = new System.Drawing.Size(800, 24);
            this.menuAlumnos.TabIndex = 0;
            this.menuAlumnos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirseAUnaMateriaToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // inscribirseAUnaMateriaToolStripMenuItem
            // 
            this.inscribirseAUnaMateriaToolStripMenuItem.Name = "inscribirseAUnaMateriaToolStripMenuItem";
            this.inscribirseAUnaMateriaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inscribirseAUnaMateriaToolStripMenuItem.Text = "Inscribirse a una materia";
            this.inscribirseAUnaMateriaToolStripMenuItem.Click += new System.EventHandler(this.inscribirseAUnaMateriaToolStripMenuItem_Click);
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeDatosToolStripMenuItem,
            this.modificacionDeDatosToolStripMenuItem});
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            // 
            // consultaDeDatosToolStripMenuItem
            // 
            this.consultaDeDatosToolStripMenuItem.Name = "consultaDeDatosToolStripMenuItem";
            this.consultaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.consultaDeDatosToolStripMenuItem.Text = "Consulta de datos";
            this.consultaDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosToolStripMenuItem_Click);
            // 
            // modificacionDeDatosToolStripMenuItem
            // 
            this.modificacionDeDatosToolStripMenuItem.Name = "modificacionDeDatosToolStripMenuItem";
            this.modificacionDeDatosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modificacionDeDatosToolStripMenuItem.Text = "Modificacion de datos";
            this.modificacionDeDatosToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeDatosToolStripMenuItem_Click);
            // 
            // estadoAcademicoToolStripMenuItem
            // 
            this.estadoAcademicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaEstadoAcademicoToolStripMenuItem});
            this.estadoAcademicoToolStripMenuItem.Name = "estadoAcademicoToolStripMenuItem";
            this.estadoAcademicoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.estadoAcademicoToolStripMenuItem.Text = "Estado Academico";
            // 
            // consultaEstadoAcademicoToolStripMenuItem
            // 
            this.consultaEstadoAcademicoToolStripMenuItem.Name = "consultaEstadoAcademicoToolStripMenuItem";
            this.consultaEstadoAcademicoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultaEstadoAcademicoToolStripMenuItem.Text = "Consulta estado academico";
            this.consultaEstadoAcademicoToolStripMenuItem.Click += new System.EventHandler(this.consultaEstadoAcademicoToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteMateriasInscriptasToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // reporteMateriasInscriptasToolStripMenuItem
            // 
            this.reporteMateriasInscriptasToolStripMenuItem.Name = "reporteMateriasInscriptasToolStripMenuItem";
            this.reporteMateriasInscriptasToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.reporteMateriasInscriptasToolStripMenuItem.Text = "Reporte Materias Inscriptas";
            this.reporteMateriasInscriptasToolStripMenuItem.Click += new System.EventHandler(this.reporteMateriasInscriptasToolStripMenuItem_Click);
            // 
            // MenuAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuAlumnos;
            this.Name = "MenuAlumno";
            this.Text = "MenuAlumno";
            this.menuAlumnos.ResumeLayout(false);
            this.menuAlumnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirseAUnaMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem estadoAcademicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEstadoAcademicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteMateriasInscriptasToolStripMenuItem;
    }
}