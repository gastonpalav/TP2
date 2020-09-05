namespace UI.Desktop
{
    partial class Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curso));
            this.tcCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlCursos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_calendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCursos.ContentPanel.SuspendLayout();
            this.tcCursos.TopToolStripPanel.SuspendLayout();
            this.tcCursos.SuspendLayout();
            this.tlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.tsCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCursos
            // 
            // 
            // tcCursos.ContentPanel
            // 
            this.tcCursos.ContentPanel.Controls.Add(this.tlCursos);
            this.tcCursos.ContentPanel.Size = new System.Drawing.Size(1438, 764);
            this.tcCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCursos.Location = new System.Drawing.Point(0, 0);
            this.tcCursos.Name = "tcCursos";
            this.tcCursos.Size = new System.Drawing.Size(1438, 806);
            this.tcCursos.TabIndex = 0;
            this.tcCursos.Text = "toolStripContainer1";
            // 
            // tcCursos.TopToolStripPanel
            // 
            this.tcCursos.TopToolStripPanel.Controls.Add(this.tsCursos);
            // 
            // tlCursos
            // 
            this.tlCursos.ColumnCount = 2;
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCursos.Controls.Add(this.dgvCursos, 0, 0);
            this.tlCursos.Controls.Add(this.btnAceptar, 0, 1);
            this.tlCursos.Controls.Add(this.btnCancelar, 1, 1);
            this.tlCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCursos.Location = new System.Drawing.Point(0, 0);
            this.tlCursos.Name = "tlCursos";
            this.tlCursos.RowCount = 2;
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursos.Size = new System.Drawing.Size(1438, 764);
            this.tlCursos.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_curso,
            this.desc_materia,
            this.desc_comision,
            this.anio_calendario,
            this.cupo});
            this.tlCursos.SetColumnSpan(this.dgvCursos, 2);
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 82;
            this.dgvCursos.RowTemplate.Height = 33;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(1432, 700);
            this.dgvCursos.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(1155, 709);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(137, 52);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Actualizar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1298, 709);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 52);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tsCursos
            // 
            this.tsCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCursos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbModificar,
            this.toolStripButton3});
            this.tsCursos.Location = new System.Drawing.Point(6, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(160, 42);
            this.tsCursos.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 36);
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
            this.tsbModificar.Size = new System.Drawing.Size(46, 36);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.ToolTipText = "Editar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton3.Text = "tsb3";
            this.toolStripButton3.ToolTipText = "Eliminar";
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "id_curso";
            this.id_curso.MinimumWidth = 10;
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            this.id_curso.Width = 200;
            // 
            // desc_materia
            // 
            this.desc_materia.DataPropertyName = "desc_materia";
            this.desc_materia.HeaderText = "Materia";
            this.desc_materia.MinimumWidth = 10;
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.ReadOnly = true;
            this.desc_materia.Width = 200;
            // 
            // desc_comision
            // 
            this.desc_comision.DataPropertyName = "Comision.Descripcion";
            this.desc_comision.HeaderText = "Comision";
            this.desc_comision.MinimumWidth = 10;
            this.desc_comision.Name = "desc_comision";
            this.desc_comision.ReadOnly = true;
            this.desc_comision.Width = 200;
            // 
            // anio_calendario
            // 
            this.anio_calendario.DataPropertyName = "anio_calendario";
            this.anio_calendario.HeaderText = "anio_calendario";
            this.anio_calendario.MinimumWidth = 10;
            this.anio_calendario.Name = "anio_calendario";
            this.anio_calendario.ReadOnly = true;
            this.anio_calendario.Width = 200;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "cupo";
            this.cupo.HeaderText = "cupo";
            this.cupo.MinimumWidth = 10;
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            this.cupo.Width = 200;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 806);
            this.Controls.Add(this.tcCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Curso";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Curso_Load);
            this.tcCursos.ContentPanel.ResumeLayout(false);
            this.tcCursos.TopToolStripPanel.ResumeLayout(false);
            this.tcCursos.TopToolStripPanel.PerformLayout();
            this.tcCursos.ResumeLayout(false);
            this.tcCursos.PerformLayout();
            this.tlCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCursos;
        private System.Windows.Forms.TableLayoutPanel tlCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_calendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
    }
}