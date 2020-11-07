namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioDesktop));
            this.tlpUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmaClave = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 4;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53192F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.46809F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpUsuarios.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tlpUsuarios.Controls.Add(this.txtClave, 1, 3);
            this.tlpUsuarios.Controls.Add(this.txtUsuario, 3, 2);
            this.tlpUsuarios.Controls.Add(this.txtEmail, 1, 2);
            this.tlpUsuarios.Controls.Add(this.txtApellido, 3, 1);
            this.tlpUsuarios.Controls.Add(this.lblClave, 0, 3);
            this.tlpUsuarios.Controls.Add(this.Email, 0, 2);
            this.tlpUsuarios.Controls.Add(this.lblNombre, 0, 1);
            this.tlpUsuarios.Controls.Add(this.lblApellido, 2, 1);
            this.tlpUsuarios.Controls.Add(this.lblUsuario, 2, 2);
            this.tlpUsuarios.Controls.Add(this.lblConfirmaClave, 2, 3);
            this.tlpUsuarios.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuarios.Controls.Add(this.lblId, 0, 0);
            this.tlpUsuarios.Controls.Add(this.txtNombre, 1, 1);
            this.tlpUsuarios.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlpUsuarios.Controls.Add(this.btnAceptar, 2, 4);
            this.tlpUsuarios.Controls.Add(this.btnCancelar, 3, 4);
            this.tlpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuarios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.RowCount = 5;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpUsuarios.Size = new System.Drawing.Size(956, 365);
            this.tlpUsuarios.TabIndex = 0;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConfirmarClave.Location = new System.Drawing.Point(645, 257);
            this.txtConfirmarClave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(292, 31);
            this.txtConfirmarClave.TabIndex = 18;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClave.Location = new System.Drawing.Point(124, 257);
            this.txtClave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(332, 31);
            this.txtClave.TabIndex = 17;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.Location = new System.Drawing.Point(645, 181);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(292, 31);
            this.txtUsuario.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(124, 181);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 31);
            this.txtEmail.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(645, 102);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(292, 31);
            this.txtApellido.TabIndex = 14;
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(6, 260);
            this.lblClave.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(67, 25);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Clave";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 184);
            this.Email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(65, 25);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 105);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(471, 105);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(89, 25);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(471, 184);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(86, 25);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConfirmaClave
            // 
            this.lblConfirmaClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirmaClave.AutoSize = true;
            this.lblConfirmaClave.Location = new System.Drawing.Point(471, 260);
            this.lblConfirmaClave.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmaClave.Name = "lblConfirmaClave";
            this.lblConfirmaClave.Size = new System.Drawing.Size(159, 25);
            this.lblConfirmaClave.TabIndex = 7;
            this.lblConfirmaClave.Text = "Confirma Clave";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Location = new System.Drawing.Point(127, 23);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(332, 31);
            this.txtID.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 26);
            this.lblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 25);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(124, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 31);
            this.txtNombre.TabIndex = 12;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(471, 24);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(140, 29);
            this.chkHabilitado.TabIndex = 19;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(471, 316);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 43);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(645, 316);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 43);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 365);
            this.Controls.Add(this.tlpUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "UsuarioDesktop";
            this.Text = "UsuarioDesktop";
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private System.Windows.Forms.Label lblConfirmaClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkHabilitado;
    }
}