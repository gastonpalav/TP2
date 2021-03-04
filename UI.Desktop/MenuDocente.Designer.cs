namespace UI.Desktop
{
    partial class MenuDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDocente));
            this.menuAlumnos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaDeCursosEinscriptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroCondicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuAlumnos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.datosPersonalesToolStripMenuItem,
            this.estadoAcademicoToolStripMenuItem});
            this.menuAlumnos.Location = new System.Drawing.Point(0, 0);
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Size = new System.Drawing.Size(948, 42);
            this.menuAlumnos.TabIndex = 1;
            this.menuAlumnos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 38);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaDeCursosEinscriptosToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // ConsultaDeCursosEinscriptosToolStripMenuItem
            // 
            this.ConsultaDeCursosEinscriptosToolStripMenuItem.Name = "ConsultaDeCursosEinscriptosToolStripMenuItem";
            this.ConsultaDeCursosEinscriptosToolStripMenuItem.Size = new System.Drawing.Size(478, 44);
            this.ConsultaDeCursosEinscriptosToolStripMenuItem.Text = "Consulta de cursos e inscriptos";
            this.ConsultaDeCursosEinscriptosToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeCursosEinscriptosToolStripMenuItem_Click);
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeDatosToolStripMenuItem,
            this.modificacionDeDatosToolStripMenuItem});
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            // 
            // consultaDeDatosToolStripMenuItem
            // 
            this.consultaDeDatosToolStripMenuItem.Name = "consultaDeDatosToolStripMenuItem";
            this.consultaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.consultaDeDatosToolStripMenuItem.Text = "Consulta de datos";
            this.consultaDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosToolStripMenuItem_Click);
            // 
            // modificacionDeDatosToolStripMenuItem
            // 
            this.modificacionDeDatosToolStripMenuItem.Name = "modificacionDeDatosToolStripMenuItem";
            this.modificacionDeDatosToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.modificacionDeDatosToolStripMenuItem.Text = "Modificacion de datos";
            this.modificacionDeDatosToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeDatosToolStripMenuItem_Click);
            // 
            // estadoAcademicoToolStripMenuItem
            // 
            this.estadoAcademicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroCondicionesToolStripMenuItem});
            this.estadoAcademicoToolStripMenuItem.Name = "estadoAcademicoToolStripMenuItem";
            this.estadoAcademicoToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.estadoAcademicoToolStripMenuItem.Text = "Registro condiciones ";
            // 
            // RegistroCondicionesToolStripMenuItem
            // 
            this.RegistroCondicionesToolStripMenuItem.Name = "RegistroCondicionesToolStripMenuItem";
            this.RegistroCondicionesToolStripMenuItem.Size = new System.Drawing.Size(375, 44);
            this.RegistroCondicionesToolStripMenuItem.Text = "Registrar condiciones";
            this.RegistroCondicionesToolStripMenuItem.Click += new System.EventHandler(this.RegistroCondicionesToolStripMenuItem_Click);
            // 
            // MenuDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 536);
            this.Controls.Add(this.menuAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuDocente";
            this.Text = "MenuDocente";
            this.menuAlumnos.ResumeLayout(false);
            this.menuAlumnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaDeCursosEinscriptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoAcademicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroCondicionesToolStripMenuItem;
    }
}