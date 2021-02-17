using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAllPersonasByType(Persona.TipoPersonas tipoPersona)
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdGetAll = new SqlCommand("SELECT *,pl.desc_plan from personas pe inner join planes pl on pl.id_plan=pe.id_plan where pe.tipo_persona = @tipo", SqlConn);
                cmdGetAll.Parameters.Add("@tipo", SqlDbType.Int).Value = tipoPersona;
                SqlDataReader drPersonas = cmdGetAll.ExecuteReader();

                while (drPersonas.Read())
                {
                    Persona per = new Persona();
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.Plan = new Plan
                    {
                        ID = (int)drPersonas["id_plan"],
                        Descripcion = (string)drPersonas["desc_plan"]
                    };

                    personas.Add(per);
                }
                drPersonas.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de Personas", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public Persona GetOne(int ID)
        {
            Persona per = new Persona();

            try
            {
                this.OpenConnection();
                SqlCommand cmdGetOne = new SqlCommand("select *,desc_plan from personas pe inner join planes p on p.id_plan=pe.id_plan where id_persona = @id", SqlConn);
                cmdGetOne.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdGetOne.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Plan = new Plan
                    {
                        ID = (int)drPersonas["id_plan"],
                        Descripcion = (string)drPersonas["desc_plan"]

                    };
                    per.Telefono = (string)drPersonas["telefono"];
                    switch ((int)drPersonas["tipo_persona"])
                    {
                        case 0:
                            per.TipoPersona = Persona.TipoPersonas.Administrador;
                            break;

                        case 1:
                            per.TipoPersona = Persona.TipoPersonas.Docente;
                            break;

                        case 2:
                            per.TipoPersona = Persona.TipoPersonas.Alumno;
                            break;
                    }
                }
                drPersonas.Close();
            }
            catch (Exception e)
            {
                Exception exp = new Exception("Error al recuperar datos de personas.", e);
                throw exp;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }

        public Persona GetOneByUsuario(string usuario)
        {
            Persona per = new Persona();

            try
            {
                this.OpenConnection();
                SqlCommand cmdGetOne = new SqlCommand("select *,desc_plan from personas pe inner join planes p on p.id_plan=pe.id_plan inner join usuarios us on pe.id_persona=us.id_persona where us.nombre_usuario = @usu", SqlConn);
                cmdGetOne.Parameters.Add("@usu", SqlDbType.VarChar).Value = usuario;
                SqlDataReader drPersonas = cmdGetOne.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Plan = new Plan
                    {
                        ID = (int)drPersonas["id_plan"],
                        Descripcion = (string)drPersonas["desc_plan"]

                    };
                    per.Telefono = (string)drPersonas["telefono"];
                    switch ((int)drPersonas["tipo_persona"])
                    {
                        case 0:
                            per.TipoPersona = Persona.TipoPersonas.Administrador;
                            break;

                        case 1:
                            per.TipoPersona = Persona.TipoPersonas.Docente;
                            break;

                        case 2:
                            per.TipoPersona = Persona.TipoPersonas.Alumno;
                            break;
                    }
                }
                drPersonas.Close();
            }
            catch (Exception e)
            {
                Exception exp = new Exception("Error al recuperar datos de personas.", e);
                throw exp;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Exception ExcepcionManejada = new Exception("Error al borrar datos de la persona por ser esta FK de otra entidad o estar inscripta a un curso", ex);
                    throw ExcepcionManejada;
                }

                throw ex;
            }
            catch (Exception ex)
            {
                Exception exp = new Exception("Error al eliminar persona", ex);
                throw exp;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE personas SET nombre=@nombre , apellido=@apellido,email=@email,direccion=@direccion,telefono=@telefono,fecha_nac=@fecha_nac,legajo=@legajo,id_plan=@id_plan, tipo_persona=@tipo_persona WHERE id_persona=@id_persona", SqlConn);
                cmdUpdate.Parameters.Add("@id_persona", SqlDbType.Int).Value = persona.ID;
                cmdUpdate.Parameters.Add("@nombre", SqlDbType.VarChar).Value = persona.Nombre;
                cmdUpdate.Parameters.Add("@email", SqlDbType.VarChar).Value = persona.Email;
                cmdUpdate.Parameters.Add("@telefono", SqlDbType.VarChar).Value = persona.Telefono;
                cmdUpdate.Parameters.Add("@direccion", SqlDbType.VarChar).Value = persona.Direccion;
                cmdUpdate.Parameters.Add("@apellido", SqlDbType.VarChar).Value = persona.ID;
                cmdUpdate.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdUpdate.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.Plan.ID;
                switch (persona.TipoPersona)
                {
                    case Persona.TipoPersonas.Administrador:
                        cmdUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 0;
                        break;

                    case Persona.TipoPersonas.Alumno:
                        cmdUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 1;
                        break;

                    case Persona.TipoPersonas.Docente:
                        cmdUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 2;
                        break;
                }

                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Exception exception = new Exception("Error al modificar datos de la persona.", e);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Persona.TipoPersonas GetTipoPersonaByUser(string user)
        {
            Persona.TipoPersonas tipo = new Persona.TipoPersonas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdGetTipo = new SqlCommand("select tipo_persona from personas pe inner join usuarios us on pe.id_persona = us.id_persona where us.nombre_usuario = @usu", SqlConn);



                cmdGetTipo.Parameters.Add("@usu", SqlDbType.VarChar).Value = user;
                SqlDataReader drPersonas = cmdGetTipo.ExecuteReader();
                if (drPersonas.Read())
                {
                    tipo = (Persona.TipoPersonas)drPersonas["tipo_persona"];
                }
                drPersonas.Close();
                return tipo;
            }
            catch (Exception ex)
            {
                Exception exception = new Exception("Error al seleccionar datos de la persona.", ex);
                throw exception;
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            persona.State = BusinessEntity.States.Unmodified;

        }

        protected void Insert(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into personas (nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan) values (@nombre,@apellido,@direccion,@mail,@telefono,@fecha_nac,@legajo,@tipo_persona,@idplan) select @@identity", SqlConn);
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdInsert.Parameters.Add("@apellido", SqlDbType.VarChar).Value = persona.Apellido;
                cmdInsert.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdInsert.Parameters.Add("@mail", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdInsert.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdInsert.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdInsert.Parameters.Add("@legajo", SqlDbType.VarChar).Value = persona.Legajo;
                cmdInsert.Parameters.Add("@idplan", SqlDbType.Int).Value = persona.Plan.ID;

                switch (persona.TipoPersona)
                {
                    case Persona.TipoPersonas.Administrador:
                        cmdInsert.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 0;
                        break;

                    case Persona.TipoPersonas.Alumno:
                        cmdInsert.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 1;
                        break;

                    case Persona.TipoPersonas.Docente:
                        cmdInsert.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 2;
                        break;
                }
                persona.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar datos de la persona", ex);
                throw ExcepcionManejada;
            }

        }

    }
}