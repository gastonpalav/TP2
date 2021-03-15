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
            try
            {
                return this.PersonaAdapter.GetTipoPersonaByUser(user);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el tipo de persona", ex);
                throw ExcepcionManejada;
            }
            
        }

        public List<Persona> GetAllPersonasByType(Persona.TipoPersonas tipoPersona)
        {
            try
            {
                return this.PersonaAdapter.GetAllPersonasByType(tipoPersona);
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de personas por tipo", ex);
                throw ExcepcionManejada;
            }
            
        }

        public Persona GetOneById(int ID)
        {
            try
            {
                return this.PersonaAdapter.GetOne(ID);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona", ex);
                throw ExcepcionManejada;
            }
            
        }

        public Persona GetOneByUser(string usuario)
        {
            try
            {
                return this.PersonaAdapter.GetOneByUsuario(usuario);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona", ex);
                throw ExcepcionManejada;
            }
            
        }

        public void Save(Persona persona)
        {
            try
            {
                this.PersonaAdapter.Save(persona);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar persona", ex);
                throw ExcepcionManejada;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.PersonaAdapter.Delete(ID);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar persona", ex);
                throw ExcepcionManejada;
            }
            
        }
}
}