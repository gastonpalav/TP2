using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ComisionAdapter :Adapter
    {
        public List<Comision> GetAll()
        {
            try
            {
                List<Comision> comisiones = new List<Comision>();
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select co.*,p.desc_plan from comisiones co inner join planes p on p.id_plan=co.id_plan", SqlConn);
                SqlDataReader drComision = cmdComision.ExecuteReader();
                while(drComision.Read())
                {
                    Comision co = new Comision();
                    co.ID = (int)drComision["id_comision"];
                    co.Descripcion = (string)drComision["desc_comision"];
                    co.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    co.Plan = new Plan
                    {
                        ID = (int)drComision["id_plan"],
                        Descripcion = (string)drComision["desc_plan"]
                    };

                    comisiones.Add(co);
                       
                }
                drComision.Close();
                this.CloseConnection();
                return comisiones;
                
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", ex);
                throw ExcepcionManejada;
            }
        }

        public Comision GetOne(int ID)
        {
            Comision comision = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select co.*,p.desc_plan from comisiones co inner join planes p on co.id_plan = p.id_plan where id_comision = @id", SqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if(drComision.Read())
                {
                    comision.ID = (int)drComision["id_comision"];
                    comision.Descripcion = (string)drComision["desc_comision"];
                    comision.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    comision.Plan = new Plan
                    {
                        ID = (int)drComision["id_plan"],
                        Descripcion = (string)drComision["desc_plan"]


                    };

                }
                drComision.Close();
                return comision;

            }
            catch (Exception ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al recuperar datos de la comision", ex);
                throw ExcepcionManjeada;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al Eliminar la comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into comisiones (anio_especialidad,desc_comision,id_plan) values (@anio_especialidad,@desc_comision,@id_plan) select @@identity", SqlConn);
                cmdInsert.Parameters.Add("@anio_especialidad", SqlDbType.Int, 50).Value = comision.AnioEspecialidad;
                cmdInsert.Parameters.Add("@desc_comision", SqlDbType.VarChar).Value = comision.Descripcion;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = comision.Plan.ID;
                comision.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar datos del curso", ex);
                throw ExcepcionManejada;
            }

        }

        protected void Update(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("Update comisiones set desc_comision=@desc_comision,anio_especialidad=@anio_especialidad,id_plan=@id_plan where id_comision=@id_comision", SqlConn);
                cmdUpdate.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdUpdate.Parameters.Add("@anio_especialidad", SqlDbType.Int, 50).Value = comision.AnioEspecialidad;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = comision.Plan.ID;
                cmdUpdate.Parameters.Add("@id_comision", SqlDbType.Int, 50).Value = comision.ID;
                cmdUpdate.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Comision comision)
        {
            if(comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            if(comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            if(comision.State==BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            comision.State = BusinessEntity.States.Unmodified;




        }
    }
}
