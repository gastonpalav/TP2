using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;


namespace Business.Logic
{
    //No hay que hacer este abm
   public class ModuloLogic : BusinessLogic 
    {
        private ModuloAdapter ModuloData;
        
        public ModuloLogic()
        {
            this.ModuloData = new ModuloAdapter();
        }
        public Modulo GetOne(int IdModulo)
        {
            return this.ModuloData.GetOne(IdModulo);
        }

        public List<Modulo> GetAll()
        {
            try
            {
                return this.ModuloData.GetAll();
            }
            catch(Exception e)
            {
                Exception exceptionManejada = new Exception("Error al recuperar la lista de modulos", e);
                throw exceptionManejada;
            }
                
        }

        public void Save(Modulo modulo)
        {
            this.ModuloData.Save(modulo);
        }

        public void Delete(int idModulo)
        {
            this.ModuloData.Delete(idModulo);
        }


    }
}
