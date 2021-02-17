using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Business.Logic
{
     public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter ComisionData;
        

        public ComisionLogic()
        {
            this.ComisionData = new ComisionAdapter();

        }

        public Comision GetOne(int idComision)
        {
            return this.ComisionData.GetOne(idComision);
        }

        public List<Comision> GetAll()
        {
            try
            {
                return this.ComisionData.GetAll();


            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de comisiones", ex);
                throw ExcepcionManejada;

            }
        }

        public void Save(Comision comision)
        {
            this.ComisionData.Save(comision);

        }


        public void Delete(int idComision)
        {
            try
            {
                this.ComisionData.Delete(idComision);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
