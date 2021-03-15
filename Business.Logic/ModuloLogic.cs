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
            try
            {
                return this.ModuloData.GetOne(IdModulo);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el modulo", ex);
                throw ExcepcionManejada;
            }
            
        }

        public List<Modulo> GetAll()
        {
            try
            {
                return this.ModuloData.GetAll();
            }
            catch(Exception ex)
            {
                Exception exceptionManejada = new Exception("Error al recuperar la lista de modulos", ex);
                throw exceptionManejada;
            }
                
        }

        public void Save(Modulo modulo)
        {
            try
            {
                this.ModuloData.Save(modulo);
            }
            catch (Exception ex)
            {
                Exception exceptionManejada = new Exception("Error al guardar el modulos", ex);
                throw exceptionManejada;
            }
            
        }

        public void Delete(int idModulo)
        {
            try
            {
                this.ModuloData.Delete(idModulo);
            }
            catch (Exception ex)
            {
                Exception exceptionManejada = new Exception("Error al eliminar el modulo", ex);
                throw exceptionManejada;
            }
            
        }


    }
}
