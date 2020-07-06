using Business.Entities;
using Business.Logic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(Modoform modo)
            : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, Modoform modo)
            : this()
        {
            this.Modo = modo;
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            this.UsuarioActual = usuarioLogic.GetOne(ID);
            this.MapearDeDatos();
        }

        #region Properties

        private Usuario _usuarioActual;

        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
            set { _usuarioActual = value; }
        }

        #endregion

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre.ToString();
            this.txtApellido.Text = this.UsuarioActual.Apellido.ToString();
            this.txtEmail.Text = this.UsuarioActual.Email.ToString();
            this.txtClave.Text = this.UsuarioActual.Clave.ToString();

            switch (this.Modo)
            {
                case Modoform.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;

                case Modoform.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;

                case Modoform.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            switch (this.Modo)
            {
                case Modoform.Alta:
                    Usuario usuario = new Usuario();

                    this.UsuarioActual = usuario;
                    this.UsuarioActual.State = BusinessEntity.States.New;
                    break;

                case Modoform.Modificacion:
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                    break;

                case Modoform.Baja:
                    this.UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;
            }

            if (this.Modo == Modoform.Alta || Modo == Modoform.Modificacion)
            {
                UsuarioActual.Apellido = this.txtApellido.Text;
                UsuarioActual.Nombre = this.txtNombre.Text;
                UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                UsuarioActual.Clave = this.txtClave.Text;
                UsuarioActual.Clave = this.txtConfirmarClave.Text;
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            }
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                UsuarioLogic usuarioLogic = new UsuarioLogic();
                usuarioLogic.Save(this.UsuarioActual);
                this.Notificar("GUARDADO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(this.txtApellido.Text) || string.IsNullOrEmpty(this.txtEmail.Text) || string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtUsuario.Text) || string.IsNullOrEmpty(this.txtClave.Text) || string.IsNullOrEmpty(this.txtConfirmarClave.Text))
            {
                this.Notificar("INFORMACION INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(this.txtClave.Text == this.txtConfirmarClave.Text))
            {
                this.Notificar("LAS CLAVES NO COINCIDEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.txtClave.Text.Count() < 8)
            {
                this.Notificar("CLAVE MUY CORTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            if (this.Modo == Modoform.Alta || this.Modo == Modoform.Modificacion)
            {
                this.GuardarCambios();
            }
            else if (this.Modo == Modoform.Baja)
            {
                this.Eliminar();
            }
        }

        private void Eliminar()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este usuario?.", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                UsuarioLogic usuarioLogic = new UsuarioLogic();
                usuarioLogic.Delete(this.UsuarioActual.ID);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}