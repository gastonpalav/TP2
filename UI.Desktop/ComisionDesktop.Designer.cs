namespace UI.Desktop
{
    partial class ComisionDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComisionDesktop));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tblComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.cboPlanDescripcion = new System.Windows.Forms.ComboBox();
            this.txtAnioEspecialidad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblAnioDescripcion = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.tblComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tblComisiones
            // 
            this.tblComisiones.ColumnCount = 4;
            this.tblComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.58472F));
            this.tblComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.41528F));
            this.tblComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tblComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tblComisiones.Controls.Add(this.cboPlanDescripcion, 3, 1);
            this.tblComisiones.Controls.Add(this.txtAnioEspecialidad, 3, 0);
            this.tblComisiones.Controls.Add(this.txtID, 1, 0);
            this.tblComisiones.Controls.Add(this.txtDescripcion, 1, 1);
            this.tblComisiones.Controls.Add(this.btnAceptar, 2, 2);
            this.tblComisiones.Controls.Add(this.btnCancelar, 3, 2);
            this.tblComisiones.Controls.Add(this.lblID, 0, 0);
            this.tblComisiones.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblComisiones.Controls.Add(this.lblAnioDescripcion, 2, 0);
            this.tblComisiones.Controls.Add(this.lblPlan, 2, 1);
            this.tblComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblComisiones.Location = new System.Drawing.Point(0, 0);
            this.tblComisiones.Name = "tblComisiones";
            this.tblComisiones.RowCount = 3;
            this.tblComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33775F));
            this.tblComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66225F));
            this.tblComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblComisiones.Size = new System.Drawing.Size(952, 302);
            this.tblComisiones.TabIndex = 1;
            // 
            // cboPlanDescripcion
            // 
            this.cboPlanDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPlanDescripcion.FormattingEnabled = true;
            this.cboPlanDescripcion.Location = new System.Drawing.Point(610, 156);
            this.cboPlanDescripcion.Name = "cboPlanDescripcion";
            this.cboPlanDescripcion.Size = new System.Drawing.Size(339, 33);
            this.cboPlanDescripcion.TabIndex = 3;
            // 
            // txtAnioEspecialidad
            // 
            this.txtAnioEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnioEspecialidad.Location = new System.Drawing.Point(610, 41);
            this.txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            this.txtAnioEspecialidad.Size = new System.Drawing.Size(339, 31);
            this.txtAnioEspecialidad.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(193, 41);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(221, 31);
            this.txtID.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(193, 157);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(221, 31);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.Location = new System.Drawing.Point(420, 234);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 65);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(610, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 65);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(184, 25);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 160);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 25);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblAnioDescripcion
            // 
            this.lblAnioDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnioDescripcion.AutoSize = true;
            this.lblAnioDescripcion.Location = new System.Drawing.Point(420, 44);
            this.lblAnioDescripcion.Name = "lblAnioDescripcion";
            this.lblAnioDescripcion.Size = new System.Drawing.Size(184, 25);
            this.lblAnioDescripcion.TabIndex = 8;
            this.lblAnioDescripcion.Text = "Anio especialidad";
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(420, 160);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(184, 25);
            this.lblPlan.TabIndex = 9;
            this.lblPlan.Text = "Plan";
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 302);
            this.Controls.Add(this.tblComisiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComisionDesktop";
            this.Text = "ComisionDesktop";
            this.tblComisiones.ResumeLayout(false);
            this.tblComisiones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tblComisiones;
        private System.Windows.Forms.ComboBox cboPlanDescripcion;
        private System.Windows.Forms.TextBox txtAnioEspecialidad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblAnioDescripcion;
        private System.Windows.Forms.Label lblPlan;
    }
}