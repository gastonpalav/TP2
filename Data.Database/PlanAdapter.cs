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

                SqlCommand cmdPlanes = new SqlCommand("Select pl.*, esp.desc_especialidad from planes pl inner join especialidades esp on pl.id_especialidad = esp.id_especialidad", SqlConn);

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Plan pln = new Plan();

                    pln.ID = (int)drPlanes["id_plan"];
                    pln.Descripcion = (string)drPlanes["desc_plan"];
                    pln.Especialidad = new Especialidad
                    {
                        ID = (int)drPlanes["id_especialidad"],
                        Descripcion = (string)drPlanes["desc_especialidad"]
                    };

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

                SqlCommand cmdPlanes = new SqlCommand("Select pl.*, esp.desc_especialidad from planes pl inner join especialidades esp on pl.id_especialidad = esp.id_especialidad where id_plan = @id ", SqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                if (drPlanes.Read())
                {                    
                    plan.ID = (int)drPlanes["id_plan"];
                    plan.Descripcion = (string)drPlanes["desc_plan"];
                    plan.Especialidad = new Especialidad
                    {
                        ID = (int)drPlanes["id_especialidad"],
                        Descripcion = (string)drPlanes["desc_especialidad"]
                    };
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
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Exception ExcepcionManejada = new Exception("Error al borrar datos del plan por ser este FK en otra entidad", ex);
                    throw ExcepcionManejada;
                }

                throw ex;
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
                    "UPDATE planes set desc_plan = @desc, id_especialidad = @id_espec " +
                    "WHERE id_plan=@id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_espec", SqlDbType.Int).Value = plan.Especialidad.ID;
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

        protected void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into planes(desc_plan, id_especialidad) " +
                    "values(@desc, @id_esp) " +
                    "select @@identity",
                    SqlConn);

                cmdInsert.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdInsert.Parameters.Add("@id_esp", SqlDbType.Int).Value = plan.Especialidad.ID;
                plan.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar plan", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

    }
}
