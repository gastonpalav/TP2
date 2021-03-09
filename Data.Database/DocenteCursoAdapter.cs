using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public void Insert(DocenteCurso docenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into docentes_cursos(id_curso,id_docente,cargo) " +
                    "values(@id_curso,@id_docente,@tipo_cargo) " +
                    "select @@identity",
                    SqlConn);

                cmdInsert.Parameters.Add("@id_curso", SqlDbType.Int, 50).Value = docenteCurso.Curso.ID;
                cmdInsert.Parameters.Add("@id_docente", SqlDbType.Int, 50).Value = docenteCurso.Docente.ID;
                switch (docenteCurso.Cargo)
                {
                    case DocenteCurso.TiposCargos.Titular:
                        cmdInsert.Parameters.Add("@tipo_cargo", SqlDbType.Int).Value = 0;
                        break;

                    case DocenteCurso.TiposCargos.Auxiliar:
                        cmdInsert.Parameters.Add("@tipo_cargo", SqlDbType.Int).Value = 1;
                        break;
                }
                docenteCurso.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al asignar docente al curso", ex);
                throw ExcepcionManejada;
            }
        }

        protected void Update(DocenteCurso docenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE docentes_cursos SET id_curso=@id_curso , id_docente=@id_docente,cargo=@tipo_cargo WHERE id_dictado=@id_dictado", SqlConn);
                cmdUpdate.Parameters.Add("@id_curso", SqlDbType.Int).Value = docenteCurso.Curso.ID;
                cmdUpdate.Parameters.Add("@id_docente", SqlDbType.Int).Value = docenteCurso.Docente.ID;
                switch (docenteCurso.Cargo)
                {
                    case DocenteCurso.TiposCargos.Titular:
                        cmdUpdate.Parameters.Add("@tipo_cargo", SqlDbType.Int).Value = 0;
                        break;

                    case DocenteCurso.TiposCargos.Auxiliar:
                        cmdUpdate.Parameters.Add("@tipo_cargo", SqlDbType.Int).Value = 1;
                        break;
                }

                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Exception exception = new Exception("Error al modificar datos de la inscripcion del docente al curso", e);
                throw exception;
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
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Exception ExcepcionManejada = new Exception("Error al borrar datos por FK", ex);
                    throw ExcepcionManejada;
                }

                throw ex;
            }
            catch (Exception ex)
            {
                Exception exp = new Exception("Error al eliminar inscripcion", ex);
                throw exp;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<DocenteCurso> GetAll()
        {
            try
            {
                List<DocenteCurso> docenteCursos = new List<DocenteCurso>();

                this.OpenConnection();

                SqlCommand cmdDocenteCurso = new SqlCommand("select dc.*, d.legajo, m.id_materia, m.desc_materia, co.id_comision, co.desc_comision from docentes_cursos dc inner join personas d on dc.id_docente=d.id_persona inner join cursos c on dc.id_curso=c.id_curso inner join materias m on c.id_materia=m.id_materia inner join comisiones co on c.id_comision=co.id_comision", SqlConn);

                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();

                while (drDocenteCurso.Read())
                {
                    var a = new DocenteCurso();

                    a.ID = (int)drDocenteCurso["id_dictado"];

                    a.Curso = new Curso
                    {
                        ID = (int)drDocenteCurso["id_curso"],
                        //AnioCalendario = (Int32)drDocenteCurso["anio_calendario"],
                        //Cupo = (Int32)drDocenteCurso["cupo"];
                        Materia = new Materia
                        {
                            ID = (int)drDocenteCurso["id_materia"],
                            Descripcion = (string)drDocenteCurso["desc_materia"]
                        },

                        Comision = new Comision
                        {
                            ID = (int)drDocenteCurso["id_comision"],
                            Descripcion = (string)drDocenteCurso["desc_comision"]
                        }
                    };

                    a.Docente = new Persona
                    {
                        ID = (int)drDocenteCurso["id_docente"],
                        Legajo = (int)drDocenteCurso["legajo"],
                    };

                    switch ((int)drDocenteCurso["cargo"])
                    {
                        case 0:
                            a.Cargo = DocenteCurso.TiposCargos.Titular;
                            break;
                        case 1:
                            a.Cargo = DocenteCurso.TiposCargos.Auxiliar;
                            break;
                    }

                    docenteCursos.Add(a);
                }
                drDocenteCurso.Close();
                this.CloseConnection();

                return docenteCursos;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de docentesCursos", ex);
                throw ExcepcionManejada;
            }
        }
        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso docenteCurso = new DocenteCurso();

            try
            {
                this.OpenConnection();
                SqlCommand cmdGetOne = new SqlCommand("select dc.id_dictado,p.legajo,ai.id_inscripcion,c.id_curso,dc.id_docente,m.desc_materia,co.desc_comision,ai.condicion,isnull(ai.nota,0) 'nota',dc.cargo from docentes_cursos dc" +
                                            " inner join cursos c on c.id_curso = dc.id_curso" +
                                            " inner join comisiones co on c.id_comision = c.id_comision" +
                                            " inner join materias m on m.id_materia = c.id_materia" +
                                            " inner join alumnos_inscripciones ai on ai.id_curso = c.id_curso" +
                                            " inner join personas p on p.id_persona = ai.id_alumno" +
                                            " where dc.id_dictado=@id", SqlConn);
                cmdGetOne.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocenteCurso = cmdGetOne.ExecuteReader();
                if (drDocenteCurso.Read())
                {
                    docenteCurso.ID = (int)drDocenteCurso["id_dictado"];


                    docenteCurso.Curso = new Curso
                    {
                        ID = (int)drDocenteCurso["id_curso"],
                        //AnioCalendario = (Int32)drDocenteCurso["anio_calendario"],
                        //Cupo = (Int32)drDocenteCurso["cupo"];
                        Materia = new Materia
                        {

                            Descripcion = (string)drDocenteCurso["desc_materia"]
                        },

                        Comision = new Comision
                        {

                            Descripcion = (string)drDocenteCurso["desc_comision"]
                        }
                    };

                    docenteCurso.Docente = new Persona
                    {
                        ID = (int)drDocenteCurso["id_docente"],

                    };

                    docenteCurso.AlumnoInscripcion = new AlumnoInscripcion
                    {
                        ID=(int)drDocenteCurso["id_inscripcion"],
                        Condicion = (string)drDocenteCurso["condicion"]
                    };




                    if ((int)drDocenteCurso["nota"] != 0)
                    {
                        docenteCurso.AlumnoInscripcion.Nota = (int)drDocenteCurso["nota"];
                    }
                    else
                    {

                    }


                    docenteCurso.AlumnoInscripcion.Alumno = new Persona
                    {
                        Legajo = (int)drDocenteCurso["legajo"]
                    };



                    switch ((int)drDocenteCurso["cargo"])
                    {
                        case 0:
                            docenteCurso.Cargo = DocenteCurso.TiposCargos.Titular;
                            break;
                        case 1:
                            docenteCurso.Cargo = DocenteCurso.TiposCargos.Auxiliar;
                            break;
                    }
                }
                drDocenteCurso.Close();

                return docenteCurso;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<DocenteCurso> GetAllbyDocente(Persona docente)
        {
            try
            {
                List<DocenteCurso> docenteCursos = new List<DocenteCurso>();

                this.OpenConnection();

                SqlCommand cmdDocenteCurso = new SqlCommand("select dc.id_dictado,p.legajo,c.id_curso,dc.id_docente,m.desc_materia,co.desc_comision,ai.condicion,isnull(ai.nota,0) 'nota',dc.cargo from docentes_cursos dc" +
                                            " inner join cursos c on c.id_curso = dc.id_curso" +
                                            " inner join comisiones co on co.id_comision = c.id_comision" +
                                            " inner join materias m on m.id_materia = c.id_materia" +
                                            " inner join alumnos_inscripciones ai on ai.id_curso = c.id_curso" +
                                            " inner join personas p on p.id_persona = ai.id_alumno" +
                                            " where dc.id_docente = @id_docente;", SqlConn);
                cmdDocenteCurso.Parameters.Add("@id_docente", SqlDbType.Int).Value = docente.ID;
                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();

                while (drDocenteCurso.Read())
                {
                    var a = new DocenteCurso();

                    a.ID = (int)drDocenteCurso["id_dictado"];


                    a.Curso = new Curso
                    {
                        ID = (int)drDocenteCurso["id_curso"],
                        //AnioCalendario = (Int32)drDocenteCurso["anio_calendario"],
                        //Cupo = (Int32)drDocenteCurso["cupo"];
                        Materia = new Materia
                        {

                            Descripcion = (string)drDocenteCurso["desc_materia"]
                        },

                        Comision = new Comision
                        {

                            Descripcion = (string)drDocenteCurso["desc_comision"]
                        }
                    };

                    a.Docente = new Persona
                    {
                        ID = (int)drDocenteCurso["id_docente"],

                    };

                    a.AlumnoInscripcion = new AlumnoInscripcion
                    {
                        Condicion = (string)drDocenteCurso["condicion"]
                    };




                if ((int)drDocenteCurso["nota"] != 0)
                    {
                    a.AlumnoInscripcion.Nota= (int)drDocenteCurso["nota"];
                    }
                    else
                    {

                    }
              

                a.AlumnoInscripcion.Alumno = new Persona
                    {
                        Legajo = (int)drDocenteCurso["legajo"]
                    };



                    switch ((int)drDocenteCurso["cargo"])
                    {
                        case 0:
                            a.Cargo = DocenteCurso.TiposCargos.Titular;
                            break;
                        case 1:
                            a.Cargo = DocenteCurso.TiposCargos.Auxiliar;
                            break;
                    }

                    docenteCursos.Add(a);
                }
                drDocenteCurso.Close();
                this.CloseConnection();

                return docenteCursos;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de docentesCursos", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(DocenteCurso dc)
        {
            if (dc.State == BusinessEntity.States.New)
            {
                this.Insert(dc);
            }
            else if (dc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(dc.ID);
            }
            else if (dc.State == BusinessEntity.States.Modified)
            {
                this.Update(dc);
            }
            dc.State = BusinessEntity.States.Unmodified;
        }
    }
}
