using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdGetAll = new SqlCommand("SELECT *,pl.desc_plan FROM personas pe, planes pl where pl.id_plan=pe.id_plan", SqlConn);
                SqlDataReader drPersonas = cmdGetAll.ExecuteReader();

                while (drPersonas.Read())
                {
                    Persona per = new Persona();
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.Plan = new Plan
                    {
                        ID = (int)drPersonas["id_plan"],
                        Descripcion = (string)drPersonas["desc_plan"]
                    };

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
                SqlCommand cmdGetOne = new SqlCommand("select * from personas where id_persona = @id", SqlConn);
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
                    per.Plan.ID = (int)drPersonas["id_plan"];
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
                cmdUpdate.Parameters.Add("@apellido", SqlDbType.Int).Value = persona.ID;
                cmdUpdate.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdUpdate.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.Plan.ID;
                switch (persona.TipoPersona)
                {
                    case Persona.TipoPersonas.Administrador:
                        cmdUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 0;
                        break;

                    case Persona.TipoPersonas.Docente:
                        cmdUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 1;
                        break;

                    case Persona.TipoPersonas.Alumno:
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
    }
}