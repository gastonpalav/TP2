using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
        private void Ingreso()
        {
            if (this.Validar(this.usuarioTextBox.Text, this.passTextBox.Text))
            {
                
                PersonaLogic personaLogic = new PersonaLogic();
                Persona.TipoPersonas tipoMenu = personaLogic.GetTipoPersonaByUser(this.usuarioTextBox.Text);
                if (tipoMenu == Persona.TipoPersonas.Administrador)
                {
                    Response.Redirect("~/MenuAdministrador.aspx");
                    

                }
                else if (tipoMenu == Persona.TipoPersonas.Alumno)
                {
                    //MenuAlumno menuAlumno = new MenuAlumno();
                    //menuAlumno.Show();
                }
                else if (tipoMenu == Persona.TipoPersonas.Docente)
                {
                    //MenuDocente menuDocente = new MenuDocente();
                    //menuDocente.Show();
                }
                else
                {
                    mensajeLabel.Text = "Tipo de Usuario ingresado no correcto o no existe";
                }
            }
            else
            {
                mensajeLabel.Text = "Usuario o contraseña incorrecto/s";
            }
        }

        protected void loginLinkButton_Click(object sender, EventArgs e)
        {
            Ingreso();
        }
    }
}