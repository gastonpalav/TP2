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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAlumno));
            this.menuAlumnos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirseAUnaMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.materiasToolStripMenuItem});
            this.menuAlumnos.Location = new System.Drawing.Point(0, 0);
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuAlumnos.Size = new System.Drawing.Size(1600, 44);
            this.menuAlumnos.TabIndex = 0;
            this.menuAlumnos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirseAUnaMateriaToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // inscribirseAUnaMateriaToolStripMenuItem
            // 
            this.inscribirseAUnaMateriaToolStripMenuItem.Name = "inscribirseAUnaMateriaToolStripMenuItem";
            this.inscribirseAUnaMateriaToolStripMenuItem.Size = new System.Drawing.Size(408, 44);
            this.inscribirseAUnaMateriaToolStripMenuItem.Text = "Inscribirse a una materia";
            this.inscribirseAUnaMateriaToolStripMenuItem.Click += new System.EventHandler(this.inscribirseAUnaMateriaToolStripMenuItem_Click);
            // 
            // MenuAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.menuAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuAlumnos;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
    }
}