using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            try
            {
                List<Plan> planes = new List<Plan>();

                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("Select * from planes", SqlConn);

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Plan pln = new Plan();

                    pln.ID = (int)drPlanes["id_plan"];
                    pln.Descripcion = (string)drPlanes["desc_plan"];
                    pln.IDEspecialidad = (int)drPlanes["id_especialidad"];

                    planes.Add(pln);
                }

                drPlanes.Close();
                this.CloseConnection();

                return planes;
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al recuperar la lista de planes", ex);
                throw excepcionManejada;
            }
        }

        public Plan GetOne(int ID)
        {
            try
            {
                Plan plan = new Plan();

                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("Select * from planes where id_plan = @id", SqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                if (drPlanes.Read())
                {                    
                    plan.ID = (int)drPlanes["id_plan"];
                    plan.Descripcion = (string)drPlanes["desc_plan"];
                    plan.IDEspecialidad = (int)drPlanes["id_especialidad"];
                }

                drPlanes.Close();
                this.CloseConnection();

                return plan;
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al recuperar el plan", ex);
                throw excepcionManejada;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete planes where id_plan=@id", SqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al Eliminar Plan", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes set desc_plan = @desc, id_especialidad = @id_espec," +
                    "WHERE id_plan=@id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_espec", SqlDbType.Int).Value = plan.IDEspecialidad;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}
