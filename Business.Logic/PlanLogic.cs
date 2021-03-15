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
            try
            {
                return this.PlanData.GetOne(IDPlan);
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar plan", ex);
                throw ExcepcionManejada;
            }
            
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
            try
            {
                this.PlanData.Save(plan);
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al guardar planes", ex);
                throw ExcepcionManejada;
            }   
            
        }

        public void Delete(int idPlan)
        {
            try
            {
                this.PlanData.Delete(idPlan);
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al eliminar planes", ex);
                throw ExcepcionManejada;
            } 
        }
    }
}
