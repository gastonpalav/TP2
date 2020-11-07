namespace UI.Desktop
{
    partial class MateriaDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaDesktop));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plan = new System.Windows.Forms.Label();
            this.lblHsTot = new System.Windows.Forms.Label();
            this.lblHsSem = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtHsSem = new System.Windows.Forms.TextBox();
            this.txtHsTot = new System.Windows.Forms.TextBox();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.89655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.10345F));
            this.tableLayoutPanel1.Controls.Add(this.plan, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHsTot, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHsSem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtHsSem, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHsTot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboPlan, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.93023F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.06977F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // plan
            // 
            this.plan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.plan.AutoSize = true;
            this.plan.Location = new System.Drawing.Point(6, 402);
            this.plan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(55, 25);
            this.plan.TabIndex = 11;
            this.plan.Text = "Plan";
            // 
            // lblHsTot
            // 
            this.lblHsTot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHsTot.AutoSize = true;
            this.lblHsTot.Location = new System.Drawing.Point(6, 340);
            this.lblHsTot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHsTot.Name = "lblHsTot";
            this.lblHsTot.Size = new System.Drawing.Size(121, 25);
            this.lblHsTot.TabIndex = 10;
            this.lblHsTot.Text = "Hs. Totales";
            // 
            // lblHsSem
            // 
            this.lblHsSem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHsSem.AutoSize = true;
            this.lblHsSem.Location = new System.Drawing.Point(6, 283);
            this.lblHsSem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHsSem.Name = "lblHsSem";
            this.lblHsSem.Size = new System.Drawing.Size(157, 25);
            this.lblHsSem.TabIndex = 9;
            this.lblHsSem.Text = "Hs. Semanales";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 148);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(227, 12);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(463, 31);
            this.txtID.TabIndex = 0;
            // 
            // txtHsSem
            // 
            this.txtHsSem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHsSem.Location = new System.Drawing.Point(227, 280);
            this.txtHsSem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHsSem.Name = "txtHsSem";
            this.txtHsSem.Size = new System.Drawing.Size(463, 31);
            this.txtHsSem.TabIndex = 2;
            // 
            // txtHsTot
            // 
            this.txtHsTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHsTot.Location = new System.Drawing.Point(227, 337);
            this.txtHsTot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHsTot.Name = "txtHsTot";
            this.txtHsTot.Size = new System.Drawing.Size(463, 31);
            this.txtHsTot.TabIndex = 3;
            // 
            // cboPlan
            // 
            this.cboPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(227, 398);
            this.cboPlan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(463, 33);
            this.cboPlan.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(227, 459);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.Location = new System.Drawing.Point(65, 459);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 44);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(227, 61);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(463, 199);
            this.txtDesc.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 15);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 25);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "MateriaDesktop";
            this.Text = "Materia";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtHsSem;
        private System.Windows.Forms.TextBox txtHsTot;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label plan;
        private System.Windows.Forms.Label lblHsTot;
        private System.Windows.Forms.Label lblHsSem;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblID;
    }
}