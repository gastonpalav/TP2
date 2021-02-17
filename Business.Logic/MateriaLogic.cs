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
            return this.MateriaData.GetOne(ID);
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
            this.MateriaData.Save(mat);
        }

        public void Delete(int ID)
        {
            try
            {
                this.MateriaData.Delete(ID);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
