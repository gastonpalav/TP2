namespace UI.Desktop
{
    partial class Docentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docentes));
            this.tcDocentes = new System.Windows.Forms.ToolStripContainer();
            this.tlDocentes = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsDocentes = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDocentes.ContentPanel.SuspendLayout();
            this.tcDocentes.TopToolStripPanel.SuspendLayout();
            this.tcDocentes.SuspendLayout();
            this.tlDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.tsDocentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDocentes
            // 
            // 
            // tcDocentes.ContentPanel
            // 
            this.tcDocentes.ContentPanel.Controls.Add(this.tlDocentes);
            this.tcDocentes.ContentPanel.Size = new System.Drawing.Size(685, 266);
            this.tcDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDocentes.Location = new System.Drawing.Point(0, 0);
            this.tcDocentes.Name = "tcDocentes";
            this.tcDocentes.Size = new System.Drawing.Size(685, 305);
            this.tcDocentes.TabIndex = 0;
            this.tcDocentes.Text = "toolStripContainer1";
            // 
            // tcDocentes.TopToolStripPanel
            // 
            this.tcDocentes.TopToolStripPanel.Controls.Add(this.tsDocentes);
            // 
            // tlDocentes
            // 
            this.tlDocentes.ColumnCount = 2;
            this.tlDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlDocentes.Controls.Add(this.dgvDocentes, 0, 0);
            this.tlDocentes.Controls.Add(this.btnActualizar, 0, 1);
            this.tlDocentes.Controls.Add(this.btnSalir, 1, 1);
            this.tlDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocentes.Location = new System.Drawing.Point(0, 0);
            this.tlDocentes.Name = "tlDocentes";
            this.tlDocentes.RowCount = 2;
            this.tlDocentes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocentes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocentes.Size = new System.Drawing.Size(685, 266);
            this.tlDocentes.TabIndex = 0;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Email,
            this.Telefono,
            this.FechaNacimiento,
            this.Plan,
            this.Legajo});
            this.tlDocentes.SetColumnSpan(this.dgvDocentes, 2);
            this.dgvDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentes.Location = new System.Drawing.Point(3, 3);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersWidth = 82;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(679, 231);
            this.dgvDocentes.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(526, 240);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(607, 240);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsDocentes
            // 
            this.tsDocentes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDocentes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsDocentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsDocentes.Location = new System.Drawing.Point(6, 0);
            this.tsDocentes.Name = "tsDocentes";
            this.tsDocentes.Size = new System.Drawing.Size(120, 39);
            this.tsDocentes.TabIndex = 0;
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(36, 36);
            this.tsbAgregar.Text = "toolStripButton1";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(36, 36);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(36, 36);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "ID Docentes";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 10;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 200;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 10;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 10;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 10;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 200;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.MinimumWidth = 10;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 200;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "PlanDescripcion";
            this.Plan.HeaderText = "Plan";
            this.Plan.MinimumWidth = 10;
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            this.Plan.Width = 200;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 305);
            this.Controls.Add(this.tcDocentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.Docentes_Load);
            this.tcDocentes.ContentPanel.ResumeLayout(false);
            this.tcDocentes.TopToolStripPanel.ResumeLayout(false);
            this.tcDocentes.TopToolStripPanel.PerformLayout();
            this.tcDocentes.ResumeLayout(false);
            this.tcDocentes.PerformLayout();
            this.tlDocentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.tsDocentes.ResumeLayout(false);
            this.tsDocentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcDocentes;
        private System.Windows.Forms.ToolStrip tsDocentes;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.TableLayoutPanel tlDocentes;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
    }
}