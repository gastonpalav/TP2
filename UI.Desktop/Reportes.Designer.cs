namespace UI.Desktop
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.btnReporteCursos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReporteCursos
            // 
            this.btnReporteCursos.Location = new System.Drawing.Point(181, 93);
            this.btnReporteCursos.Name = "btnReporteCursos";
            this.btnReporteCursos.Size = new System.Drawing.Size(155, 23);
            this.btnReporteCursos.TabIndex = 0;
            this.btnReporteCursos.Text = "Reporte Cursos";
            this.btnReporteCursos.UseVisualStyleBackColor = true;
            this.btnReporteCursos.Click += new System.EventHandler(this.btnReporteCursos_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 304);
            this.Controls.Add(this.btnReporteCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteCursos;
    }
}