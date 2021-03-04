using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

     
        private void Login()
        {
            if(!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (this.Validar(this.txtUsuario.Text, this.txtPassword.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    PersonaLogic personaLogic = new PersonaLogic();
                    Persona.TipoPersonas tipoMenu = personaLogic.GetTipoPersonaByUser(this.txtUsuario.Text);
                    if (tipoMenu == Persona.TipoPersonas.Administrador)
                    {
                        MenuAdministrador menuAdministrador = new MenuAdministrador();
                        menuAdministrador.Show();
                    }
                    else if (tipoMenu == Persona.TipoPersonas.Alumno)
                    {
                        MenuAlumno menuAlumno = new MenuAlumno(this.txtUsuario.Text);
                        menuAlumno.Show();
                    }
                    else if (tipoMenu == Persona.TipoPersonas.Docente)
                    {
                        MenuDocente menuDocente = new MenuDocente(this.txtUsuario.Text);
                        menuDocente.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de usuario incorrecto", "Login"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña vacios", "Login"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool Validar(string usuario, string contraseña)
        {
            try
            {
                UsuarioLogic usuarioLogic = new UsuarioLogic();
                return usuarioLogic.Authenticate(usuario, contraseña);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}