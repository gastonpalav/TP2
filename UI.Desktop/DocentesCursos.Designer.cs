namespace UI.Desktop
{
    partial class DocentesCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocentesCursos));
            this.tcDocentesCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlDocentesCursos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocentesCursos = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tsDocentesCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id_dictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDocentesCursos.ContentPanel.SuspendLayout();
            this.tcDocentesCursos.TopToolStripPanel.SuspendLayout();
            this.tcDocentesCursos.SuspendLayout();
            this.tlDocentesCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).BeginInit();
            this.tsDocentesCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDocentesCursos
            // 
            // 
            // tcDocentesCursos.ContentPanel
            // 
            this.tcDocentesCursos.ContentPanel.Controls.Add(this.tlDocentesCursos);
            this.tcDocentesCursos.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcDocentesCursos.ContentPanel.Size = new System.Drawing.Size(762, 307);
            this.tcDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tcDocentesCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcDocentesCursos.Name = "tcDocentesCursos";
            this.tcDocentesCursos.Size = new System.Drawing.Size(762, 346);
            this.tcDocentesCursos.TabIndex = 0;
            this.tcDocentesCursos.Text = "toolStripContainer1";
            // 
            // tcDocentesCursos.TopToolStripPanel
            // 
            this.tcDocentesCursos.TopToolStripPanel.Controls.Add(this.tsDocentesCursos);
            // 
            // tlDocentesCursos
            // 
            this.tlDocentesCursos.ColumnCount = 2;
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlDocentesCursos.Controls.Add(this.dgvDocentesCursos, 0, 0);
            this.tlDocentesCursos.Controls.Add(this.btnAceptar, 0, 1);
            this.tlDocentesCursos.Controls.Add(this.btnCancelar, 1, 1);
            this.tlDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tlDocentesCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlDocentesCursos.Name = "tlDocentesCursos";
            this.tlDocentesCursos.RowCount = 2;
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocentesCursos.Size = new System.Drawing.Size(762, 307);
            this.tlDocentesCursos.TabIndex = 0;
            // 
            // dgvDocentesCursos
            // 
            this.dgvDocentesCursos.AllowUserToAddRows = false;
            this.dgvDocentesCursos.AllowUserToDeleteRows = false;
            this.dgvDocentesCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentesCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dictado,
            this.legajo,
            this.desc_curso,
            this.cargo});
            this.tlDocentesCursos.SetColumnSpan(this.dgvDocentesCursos, 2);
            this.dgvDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentesCursos.Location = new System.Drawing.Point(2, 2);
            this.dgvDocentesCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDocentesCursos.Name = "dgvDocentesCursos";
            this.dgvDocentesCursos.ReadOnly = true;
            this.dgvDocentesCursos.RowHeadersWidth = 82;
            this.dgvDocentesCursos.RowTemplate.Height = 33;
            this.dgvDocentesCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentesCursos.Size = new System.Drawing.Size(758, 272);
            this.dgvDocentesCursos.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(620, 278);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 27);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Actualizar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(692, 278);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 27);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tsDocentesCursos
            // 
            this.tsDocentesCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDocentesCursos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsDocentesCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbModificar,
            this.tsbEliminar});
            this.tsDocentesCursos.Location = new System.Drawing.Point(6, 0);
            this.tsDocentesCursos.Name = "tsDocentesCursos";
            this.tsDocentesCursos.Size = new System.Drawing.Size(120, 39);
            this.tsDocentesCursos.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(36, 36);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(36, 36);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.ToolTipText = "Editar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(36, 36);
            this.tsbEliminar.Text = "tsb3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // id_dictado
            // 
            this.id_dictado.DataPropertyName = "ID";
            this.id_dictado.HeaderText = "ID";
            this.id_dictado.MinimumWidth = 10;
            this.id_dictado.Name = "id_dictado";
            this.id_dictado.ReadOnly = true;
            this.id_dictado.Width = 200;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "LegajoDocente";
            this.legajo.HeaderText = "Docente";
            this.legajo.MinimumWidth = 10;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 200;
            // 
            // desc_curso
            // 
            this.desc_curso.DataPropertyName = "CursoDescripcion";
            this.desc_curso.HeaderText = "Curso";
            this.desc_curso.MinimumWidth = 10;
            this.desc_curso.Name = "desc_curso";
            this.desc_curso.ReadOnly = true;
            this.desc_curso.Width = 200;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "Cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.MinimumWidth = 10;
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 200;
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 346);
            this.Controls.Add(this.tcDocentesCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DocentesCursos";
            this.Text = "Docentes Cursos";
            this.Load += new System.EventHandler(this.Curso_Load);
            this.tcDocentesCursos.ContentPanel.ResumeLayout(false);
            this.tcDocentesCursos.TopToolStripPanel.ResumeLayout(false);
            this.tcDocentesCursos.TopToolStripPanel.PerformLayout();
            this.tcDocentesCursos.ResumeLayout(false);
            this.tcDocentesCursos.PerformLayout();
            this.tlDocentesCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).EndInit();
            this.tsDocentesCursos.ResumeLayout(false);
            this.tsDocentesCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcDocentesCursos;
        private System.Windows.Forms.TableLayoutPanel tlDocentesCursos;
        private System.Windows.Forms.DataGridView dgvDocentesCursos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip tsDocentesCursos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}