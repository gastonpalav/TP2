using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        private PersonaAdapter PersonaAdapter;

        public PersonaLogic()
        {
            this.PersonaAdapter = new PersonaAdapter();
        }

        public Persona.TipoPersonas GetTipoPersonaByUser(string user)
        {
            return this.PersonaAdapter.GetTipoPersonaByUser(user);
        }

        public List<Persona> GetAllPersonasByType(Persona.TipoPersonas tipoPersona)
        {
            return this.PersonaAdapter.GetAllPersonasByType(tipoPersona);
        }

        public Persona GetOneById(int ID)
        {
            return this.PersonaAdapter.GetOne(ID);
        }

        public Persona GetOneByUser(string usuario)
        {
            return this.PersonaAdapter.GetOneByUsuario(usuario);
        }

        public void Save(Persona persona)
        {
            try
            {
                this.PersonaAdapter.Save(persona);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int ID)
        {
            this.PersonaAdapter.Delete(ID);     
        }
}
}