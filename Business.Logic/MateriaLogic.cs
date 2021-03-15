using System;
using System.Collections.Generic;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        private MateriaAdapter MateriaData;

        public MateriaLogic()
        {
            this.MateriaData = new MateriaAdapter();
        }

        public Materia GetOne(int ID)
        {
            try
            {
                return this.MateriaData.GetOne(ID);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar materias", ex);
                throw ExcepcionManejada;
            }
            
        }

        public List<Materia> GetAll()
        {
            try
            {
                return this.MateriaData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de materias", ex);
                throw ExcepcionManejada;
            }
        }
        public void Save(Materia mat)
        {
            try
            {
                this.MateriaData.Save(mat);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar materia", ex);
                throw ExcepcionManejada;
            }
            
        }

        public void Delete(int ID)
        {
            try
            {
                this.MateriaData.Delete(ID);

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la materia", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
