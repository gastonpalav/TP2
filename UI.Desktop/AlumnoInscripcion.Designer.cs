namespace UI.Desktop
{
    partial class AlumnoInscripcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comisión";
            // 
            // cboMaterias
            // 
            this.cboMaterias.DisplayMember = "Descripcion";
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(110, 61);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(143, 21);
            this.cboMaterias.TabIndex = 2;
            this.cboMaterias.ValueMember = "Id";
            this.cboMaterias.SelectionChangeCommitted += new System.EventHandler(this.cboMaterias_SelectionChangeCommitted);
            // 
            // cboComision
            // 
            this.cboComision.Enabled = false;
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(110, 153);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(143, 21);
            this.cboComision.TabIndex = 3;
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.Location = new System.Drawing.Point(86, 255);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(75, 23);
            this.btnInscripcion.TabIndex = 4;
            this.btnInscripcion.Text = "Inscribir";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AlumnoInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 309);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInscripcion);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlumnoInscripcion";
            this.Text = "Inscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Button btnCancelar;
    }
}