using Business.Entities;
using Data.Database;
using System.Collections.Generic;
using System;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private EspecialidadAdapter especialidadData;

        public EspecialidadLogic()
        {
            this.especialidadData = new EspecialidadAdapter();
        }

        public Especialidad GetOne(int ID)
        {
            try
            {
                return this.especialidadData.GetOne(ID);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al especialidad", ex);
                throw ExcepcionManejada;
            }
            
        }

        public List<Especialidad> GetAll()
        {
            try
            {
                return this.especialidadData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de especialidad", ex);
                throw ExcepcionManejada;
            }
            
        }

        public void Save(Especialidad especialidad)
        {
            try
            {
                especialidadData.Save(especialidad);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la especialidad", ex);
                throw ExcepcionManejada;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                especialidadData.Delete(id);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar especialidad", ex);
                throw ExcepcionManejada;
            }

        }
    }
}