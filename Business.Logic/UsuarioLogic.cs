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
            return this.UsuarioData.GetOne(idUsuario);
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
            this.UsuarioData.Save(usuario);
        }

        public void Delete(int idUsuario)
        {
            this.UsuarioData.Delete(idUsuario);
        }

        public bool Authenticate(string usuario, string contraseña)
        {
            try
            {
                return this.UsuarioData.Authenticate(usuario, contraseña);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}