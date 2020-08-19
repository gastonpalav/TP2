using System;
using System.Collections.Generic;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        private PlanAdapter PlanData;

        public PlanLogic()
        {
            this.PlanData = new PlanAdapter();
        }

        public Plan GetOne(int IDPlan)
        {
            return this.PlanData.GetOne(IDPlan);
        }

        public List<Plan> GetAll()
        {
            try
            {
                return this.PlanData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de planes", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Plan plan)
        {
            this.PlanData.Save(plan);
        }

        public void Delete(int idPlan)
        {
            this.PlanData.Delete(idPlan);
        }
    }
}
