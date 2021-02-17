using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            try
            {
                List<Materia> materias = new List<Materia>();

                this.OpenConnection();

                SqlCommand cmdMaterias = new SqlCommand("Select mat.*, pl.desc_plan from materias mat inner join planes pl on mat.id_plan = pl.id_plan ", SqlConn);

                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    Materia mat = new Materia();

                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    mat.HSTotales = (int)drMaterias["hs_totales"];

                    mat.Plan = new Plan
                    {
                        ID = (int)drMaterias["id_plan"],
                        Descripcion = (string)drMaterias["desc_plan"]
                    };

                    materias.Add(mat);
                }

                drMaterias.Close();
                this.CloseConnection();

                return materias;

            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al recuperar la lista de materias", ex);
                throw excepcionManejada;
            }
        }

        public Materia GetOne(int IDMateria)
        {
            try
            {
                Materia mat = new Materia();

                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("Select mat.*, pl.desc_plan from materias mat inner join planes pl on mat.id_plan = pl.id_plan where id_materia = @IDMateria ", SqlConn);
                cmdMateria.Parameters.Add("@IDMateria", SqlDbType.Int).Value = IDMateria;
                SqlDataReader drMaterias = cmdMateria.ExecuteReader();

                if (drMaterias.Read())
                {
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    mat.HSTotales = (int)drMaterias["hs_totales"];

                    mat.Plan = new Plan
                    {
                        ID = (int)drMaterias["id_plan"],
                        Descripcion = (string)drMaterias["desc_plan"]
                    };
                }

                drMaterias.Close();
                this.CloseConnection();

                return mat;
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al recuperar la materia", ex);
                throw excepcionManejada;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia=@id", SqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Exception ExcepcionManejada = new Exception("Error al borrar datos de la materia por ser esta FK de otra entidad", ex);
                    throw ExcepcionManejada;
                }

                throw ex;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al Eliminar Materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE materias set desc_materia = @desc, hs_semanales = @hss, hs_totales = @hst, id_plan = @idplan where id_materia = @idmat", SqlConn);
                
                cmdSave.Parameters.Add("@idmat", SqlDbType.Int).Value = mat.ID;
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdSave.Parameters.Add("@idplan", SqlDbType.Int).Value = mat.Plan.ID;
                cmdSave.Parameters.Add("@hss", SqlDbType.Int).Value = mat.HSSemanales;
                cmdSave.Parameters.Add("@hst", SqlDbType.Int).Value = mat.HSTotales;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values (@desc, @hss, @hst, @idplan) select @@identity ", SqlConn);
                
                cmdInsert.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdInsert.Parameters.Add("@idplan", SqlDbType.Int).Value = mat.Plan.ID;
                cmdInsert.Parameters.Add("@hss", SqlDbType.Int).Value = mat.HSSemanales;
                cmdInsert.Parameters.Add("@hst", SqlDbType.Int).Value = mat.HSTotales;
                mat.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar materia", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Materia mat)
        {
            if (mat.State == BusinessEntity.States.New)
            {
                this.Insert(mat);
            }
            else if (mat.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mat.ID);
            }
            else if (mat.State == BusinessEntity.States.Modified)
            {
                this.Update(mat);
            }
            mat.State = BusinessEntity.States.Unmodified;
        }
    }
}
