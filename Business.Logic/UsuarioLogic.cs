using Business.Entities;
using Data.Database;
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
            return this.UsuarioData.GetAll();
        }

        public void Save(Usuario usuario)
        {
            this.UsuarioData.Save(usuario);
        }

        public void Delete(int idUsuario)
        {
            this.UsuarioData.Delete(idUsuario);
        }
    }
}