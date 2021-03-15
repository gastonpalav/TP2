using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter UsuarioData;

        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int idUsuario)
        {
            try
            {
                return this.UsuarioData.GetOne(idUsuario);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el usuario", ex);
                throw ExcepcionManejada;
            }
            
        }

        public List<Usuario> GetAll()
        {
            try
            {
                return this.UsuarioData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Usuario usuario)
        {
            try
            {
                this.UsuarioData.Save(usuario);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar usuario", ex);
                throw ExcepcionManejada;
            }
           
        }

        public void Delete(int idUsuario)
        {
            try
            {
                this.UsuarioData.Delete(idUsuario);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error eliminar usuario", ex);
                throw ExcepcionManejada;
            }
            
        }

        public bool Authenticate(string usuario, string contraseña)
        {
            try
            {
                return this.UsuarioData.Authenticate(usuario, contraseña);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al autentificar", ex);
                throw ExcepcionManejada;
            }
        }
    }
}