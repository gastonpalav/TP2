namespace UI.Desktop
{
    partial class CursoDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursoDesktop));
            this.tblCursos = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.lblIdcomision = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAnioCalendario = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.tblCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCursos
            // 
            this.tblCursos.ColumnCount = 4;
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.97196F));
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.02804F));
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tblCursos.Controls.Add(this.lblId, 0, 0);
            this.tblCursos.Controls.Add(this.lblIdMateria, 0, 1);
            this.tblCursos.Controls.Add(this.lblIdcomision, 0, 2);
            this.tblCursos.Controls.Add(this.lblAnioCalendario, 2, 0);
            this.tblCursos.Controls.Add(this.lblCupo, 2, 1);
            this.tblCursos.Controls.Add(this.txtID, 1, 0);
            this.tblCursos.Controls.Add(this.txtAnioCalendario, 3, 0);
            this.tblCursos.Controls.Add(this.txtCupo, 3, 1);
            this.tblCursos.Controls.Add(this.btnAceptar, 2, 3);
            this.tblCursos.Controls.Add(this.btnCancelar, 3, 3);
            this.tblCursos.Controls.Add(this.cboMateria, 1, 1);
            this.tblCursos.Controls.Add(this.cboComision, 1, 2);
            this.tblCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCursos.Location = new System.Drawing.Point(0, 0);
            this.tblCursos.Name = "tblCursos";
            this.tblCursos.RowCount = 4;
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblCursos.Size = new System.Drawing.Size(974, 390);
            this.tblCursos.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(123, 25);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Location = new System.Drawing.Point(3, 157);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(123, 25);
            this.lblIdMateria.TabIndex = 3;
            this.lblIdMateria.Text = "Materia";
            // 
            // lblIdcomision
            // 
            this.lblIdcomision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdcomision.AutoSize = true;
            this.lblIdcomision.Location = new System.Drawing.Point(3, 266);
            this.lblIdcomision.Name = "lblIdcomision";
            this.lblIdcomision.Size = new System.Drawing.Size(123, 25);
            this.lblIdcomision.TabIndex = 4;
            this.lblIdcomision.Text = "Comision";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(449, 45);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(238, 25);
            this.lblAnioCalendario.TabIndex = 5;
            this.lblAnioCalendario.Text = "Anio calendario";
            this.lblAnioCalendario.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(449, 157);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(238, 25);
            this.lblCupo.TabIndex = 6;
            this.lblCupo.Text = "Cupo";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Location = new System.Drawing.Point(132, 42);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(311, 31);
            this.txtID.TabIndex = 7;
            // 
            // txtAnioCalendario
            // 
            this.txtAnioCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnioCalendario.Location = new System.Drawing.Point(693, 42);
            this.txtAnioCalendario.Name = "txtAnioCalendario";
            this.txtAnioCalendario.Size = new System.Drawing.Size(278, 31);
            this.txtAnioCalendario.TabIndex = 10;
            // 
            // txtCupo
            // 
            this.txtCupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCupo.Location = new System.Drawing.Point(693, 154);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(278, 31);
            this.txtCupo.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Location = new System.Drawing.Point(449, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(137, 51);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(693, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 51);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(132, 118);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(121, 33);
            this.cboMateria.TabIndex = 12;
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(132, 228);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(121, 33);
            this.cboComision.TabIndex = 13;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 390);
            this.Controls.Add(this.tblCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CursoDesktop";
            this.Text = "CursoDestkop";
            this.tblCursos.ResumeLayout(false);
            this.tblCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCursos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label lblIdcomision;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAnioCalendario;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboComision;
    }
}