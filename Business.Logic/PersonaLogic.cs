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

        public Persona GetOneById(int iD)
        {
            throw new NotImplementedException();
        }
    }
}