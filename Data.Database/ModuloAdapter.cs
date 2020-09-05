using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    //No hay que hacer este abm 
    public class ModuloAdapter : Adapter
    {
        public List<Modulo> GetAll()
        {
            try
            {
                List<Modulo> modulos = new List<Modulo>();
                this.OpenConnection();
                SqlCommand cmdModulos = new SqlCommand("select * from modulos", SqlConn);
                SqlDataReader drModulos = cmdModulos.ExecuteReader();
                while (drModulos.Read())
                {
                    Modulo mdl = new Modulo();
                    mdl.ID = (int)drModulos["id_modulo"];
                    mdl.Descripcion = (string)drModulos["desc_modulo"];
                    


                    modulos.Add(mdl);
                }
                drModulos.Close();
                this.CloseConnection();
                return modulos;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de modulos", ex);
                throw ExcepcionManejada;
            }
            //finally
            //{
            //    this.CloseConnection();
            //}
        }

        public Modulo GetOne(int ID)
        {
            Modulo modulo = new Modulo();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("select * from modulos where id_modulo=@id", SqlConn);
                cmdModulo.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                if (drModulo.Read())
                {
                    modulo.ID = (int)drModulo["id_modulo"];
                    modulo.Descripcion = (string)drModulo["desc_modulo"];
                    

                }
                drModulo.Close();
                return modulo;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al recuperar datos del modulo", ex);
                throw ExcepcionManejeada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete modulos where id_modulo=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            } catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar modulo", ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }

        }

        protected void Update(Modulo modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE modulos set desc_modulo = @desc_modulo,ejecuta=@ejecuta  " +
                    "WHERE id_modulo=@id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = modulo.ID;
                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        protected void Insert(Modulo modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into modulos(desc_modulo,ejecuta)" +
                    "values(@desc_modulo,@ejecuta)" +
                    "select @@identity",
                    SqlConn);

                cmdInsert.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                

                modulo.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar datos del modulo", ex);
                throw ExcepcionManejada;
            }
        }
        public void Save(Modulo modulo)
        {
            if (modulo.State==BusinessEntity.States.New)
            {
                this.Insert(modulo);
            }
            else if(modulo.State==BusinessEntity.States.Deleted)
            {
                this.Delete(modulo.ID);
            }
            else if(modulo.State==BusinessEntity.States.Modified)
            {
                this.Update(modulo);
            }
            modulo.State = BusinessEntity.States.Unmodified;

        }
    }
}

       
        

        
 