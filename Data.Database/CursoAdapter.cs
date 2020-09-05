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
                        
                    cs.Comision=new Comision
                    {
                        ID= (int)drCurso["id_comision"],
                        Descripcion=(string)drCurso["desc_comision"]
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
            //finally
            //{
            //    this.CloseConnection();
            //}
        }

        public Curso GetOne(int ID)
        {
            Curso curso = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select cu.*,m.desc_materia,co.desc_curso from cursos cu where id_curso = @id inner join materia m on cu.id_materia=m.id_materia inner join comision co on cu.id_comision=co.id_comision", SqlConn);
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
                //Quilombo con las FK, RESOLVER
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE cursos set anio_calendario=@anio_calendario,cupo=@cupo " +
                    "WHERE id_curso=@id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                //cmdSave.Parameters.Add("@", SqlDbType.VarChar, 50).Value = curso.IDComision;
                //cmdSave.Parameters.Add("@", SqlDbType.VarChar, 50).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Bit).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.VarChar, 50).Value = curso.Cupo;
               
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del curso", Ex);
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
                //Tambien quilombo con las FK
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into cursos(id_materia,id_comision,anio_calendario,cupo) " +
                    "values(1,1,@anio_calendario,@cupo) " +
                    "select @@identity",
                    SqlConn);

                
                cmdInsert.Parameters.Add("@anio_calendario", SqlDbType.VarChar, 50).Value = curso.AnioCalendario;
                cmdInsert.Parameters.Add("@cupo", SqlDbType.VarChar, 50).Value = curso.Cupo;
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
    
