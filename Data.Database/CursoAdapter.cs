using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            try
            {
                List<Curso> cursos = new List<Curso>();

                this.OpenConnection();

                SqlCommand cmdCurso = new SqlCommand("select cu.*,m.desc_materia,co.desc_comision from cursos cu inner join materias m on cu.id_materia=m.id_materia inner join comisiones co on cu.id_comision=co.id_comision", SqlConn);

                SqlDataReader drCurso = cmdCurso.ExecuteReader();

                while (drCurso.Read())
                {
                    Curso cs = new Curso();

                    cs.ID = (int)drCurso["id_curso"];
                    cs.AnioCalendario = (Int32)drCurso["anio_calendario"];
                    cs.Cupo = (Int32)drCurso["cupo"];
                    cs.Materia = new Materia
                    {
                        ID = (int)drCurso["id_materia"],
                        Descripcion = (string)drCurso["desc_materia"]
                    };

                    cs.Comision = new Comision
                    {
                        ID = (int)drCurso["id_comision"],
                        Descripcion = (string)drCurso["desc_comision"]
                    };

                    cursos.Add(cs);
                }
                drCurso.Close();
                this.CloseConnection();

                return cursos;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", ex);
                throw ExcepcionManejada;
            }
        }

        public List<Curso> BuscarComisionesPorMateria(string materia)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand("select cu.id_comision, co.desc_comision from cursos cu inner join comisiones co on cu.id_comision = co.id_comision where id_materia = @id_materia and anio_calendario = @anio_calendario", SqlConn);
                sqlCommand.Parameters.Add("@id_materia", SqlDbType.Int).Value = materia;
                sqlCommand.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = DateTime.Today.Year;
                SqlDataReader drCurso = sqlCommand.ExecuteReader();

                while (drCurso.Read())
                {
                    Curso c = new Curso();
                    c.Comision.ID = (int)drCurso["id_comision"];
                    c.Comision.Descripcion = (string)drCurso["desc_comision"];
                    cursos.Add(c);
                }

                drCurso.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de los Cursos.", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Curso GetOne(int ID)
        {
            Curso curso = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select cu.*,m.desc_materia,co.desc_comision from cursos cu  inner join materias m on cu.id_materia=m.id_materia inner join comisiones co on cu.id_comision=co.id_comision where id_curso = @id", SqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if (drCurso.Read())
                {
                    curso.ID = (int)drCurso["id_curso"];
                    curso.Materia = new Materia
                    {
                        ID = (int)drCurso["id_materia"],
                        Descripcion = (string)drCurso["desc_materia"]
                    };

                    curso.Comision = new Comision
                    {
                        ID = (int)drCurso["id_comision"],
                        Descripcion = (string)drCurso["desc_comision"]
                    };
                    curso.AnioCalendario = (Int32)drCurso["anio_calendario"];
                    curso.Cupo = (Int32)drCurso["cupo"];
                }
                drCurso.Close();
                return curso;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al recuperar datos del curso", ex);
                throw ExcepcionManjeada;
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

                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso=@id", SqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Exception ExcepcionManejada = new Exception("Error al borrar datos del curso por ser este FK de otra entidad", ex);
                    throw ExcepcionManejada;
                }

                throw ex;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al Eliminar curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE cursos set anio_calendario=@anio_calendario,cupo=@cupo,id_materia=@id_materia,id_comision=@id_comision " +
                    "WHERE id_curso=@id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int, 50).Value = curso.ID;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int, 50).Value = curso.Comision.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int, 50).Value = curso.Materia.ID;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int, 50).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int, 50).Value = curso.Cupo;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into cursos(id_materia,id_comision,anio_calendario,cupo) " +
                    "values(@id_materia,@id_comision,@anio_calendario,@cupo) " +
                    "select @@identity",
                    SqlConn);

                cmdInsert.Parameters.Add("@anio_calendario", SqlDbType.Int, 50).Value = curso.AnioCalendario;
                cmdInsert.Parameters.Add("@cupo", SqlDbType.Int, 50).Value = curso.Cupo;
                cmdInsert.Parameters.Add("@id_materia", SqlDbType.Int, 50).Value = curso.Materia.ID;
                cmdInsert.Parameters.Add("@id_comision", SqlDbType.Int, 50).Value = curso.Comision.ID;
                curso.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar datos del curso", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}