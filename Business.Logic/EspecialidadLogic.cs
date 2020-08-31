using Business.Entities;
using Data.Database;
using System.Collections.Generic;

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
            return this.especialidadData.GetOne(ID);
        }

        public List<Especialidad> GetAll()
        {
            return this.especialidadData.GetAll();
        }

        public void Save(Especialidad especialidad)
        {
            especialidadData.Save(especialidad);
        }

        public void Delete(int id)
        {
            especialidadData.Delete(id);
        }
    }
}