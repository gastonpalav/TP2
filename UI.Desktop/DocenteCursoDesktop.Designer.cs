namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteCursoDesktop));
            this.tblCursos = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLegajoDocente = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboDocente = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cboCargos = new System.Windows.Forms.ComboBox();
            this.lblDescCurso = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tblCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCursos
            // 
            this.tblCursos.ColumnCount = 4;
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.97196F));
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.02804F));
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tblCursos.Controls.Add(this.lblId, 0, 0);
            this.tblCursos.Controls.Add(this.lblLegajoDocente, 0, 1);
            this.tblCursos.Controls.Add(this.txtID, 1, 0);
            this.tblCursos.Controls.Add(this.cboDocente, 1, 1);
            this.tblCursos.Controls.Add(this.lblCargo, 2, 1);
            this.tblCursos.Controls.Add(this.cboCargos, 3, 1);
            this.tblCursos.Controls.Add(this.lblDescCurso, 2, 0);
            this.tblCursos.Controls.Add(this.cboCurso, 3, 0);
            this.tblCursos.Controls.Add(this.btnAceptar, 2, 2);
            this.tblCursos.Controls.Add(this.btnCancelar, 3, 2);
            this.tblCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCursos.Location = new System.Drawing.Point(0, 0);
            this.tblCursos.Margin = new System.Windows.Forms.Padding(2);
            this.tblCursos.Name = "tblCursos";
            this.tblCursos.RowCount = 3;
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCursos.Size = new System.Drawing.Size(487, 203);
            this.tblCursos.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(2, 31);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // lblLegajoDocente
            // 
            this.lblLegajoDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLegajoDocente.AutoSize = true;
            this.lblLegajoDocente.Location = new System.Drawing.Point(2, 104);
            this.lblLegajoDocente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegajoDocente.Name = "lblLegajoDocente";
            this.lblLegajoDocente.Size = new System.Drawing.Size(60, 13);
            this.lblLegajoDocente.TabIndex = 3;
            this.lblLegajoDocente.Text = "Docente";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Location = new System.Drawing.Point(66, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 20);
            this.txtID.TabIndex = 7;
            // 
            // cboDocente
            // 
            this.cboDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDocente.FormattingEnabled = true;
            this.cboDocente.Location = new System.Drawing.Point(66, 100);
            this.cboDocente.Margin = new System.Windows.Forms.Padding(2);
            this.cboDocente.Name = "cboDocente";
            this.cboDocente.Size = new System.Drawing.Size(152, 21);
            this.cboDocente.TabIndex = 12;
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(222, 104);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(118, 13);
            this.lblCargo.TabIndex = 15;
            this.lblCargo.Text = "Cargo";
            // 
            // cboCargos
            // 
            this.cboCargos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCargos.FormattingEnabled = true;
            this.cboCargos.Location = new System.Drawing.Point(344, 100);
            this.cboCargos.Margin = new System.Windows.Forms.Padding(2);
            this.cboCargos.Name = "cboCargos";
            this.cboCargos.Size = new System.Drawing.Size(139, 21);
            this.cboCargos.TabIndex = 14;
            // 
            // lblDescCurso
            // 
            this.lblDescCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescCurso.AutoSize = true;
            this.lblDescCurso.Location = new System.Drawing.Point(222, 31);
            this.lblDescCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescCurso.Name = "lblDescCurso";
            this.lblDescCurso.Size = new System.Drawing.Size(118, 13);
            this.lblDescCurso.TabIndex = 4;
            this.lblDescCurso.Text = "Curso";
            // 
            // cboCurso
            // 
            this.cboCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(344, 27);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(2);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(141, 21);
            this.cboCurso.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Location = new System.Drawing.Point(222, 161);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 27);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(344, 161);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 27);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 203);
            this.Controls.Add(this.tblCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocenteCursoDesktop";
            this.Text = "DocenteCursoDestkop";
            this.tblCursos.ResumeLayout(false);
            this.tblCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCursos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLegajoDocente;
        private System.Windows.Forms.Label lblDescCurso;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboDocente;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboCargos;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}