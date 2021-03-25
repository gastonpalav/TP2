using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter, IAlumnoInscripcionAdapter
    {
        public void Insert(AlumnoInscripcion alumnoInscripcion)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into Alumnos_inscripciones(id_alumno,id_curso,condicion) " +
                    "values(@id_alumno,@id_curso,@condicion) " +
                    "select @@identity",
                    SqlConn);

                cmdInsert.Parameters.Add("@id_alumno", SqlDbType.Int, 50).Value = alumnoInscripcion.IDAlumno;
                cmdInsert.Parameters.Add("@id_curso", SqlDbType.Int, 50).Value = alumnoInscripcion.IDCurso;
                cmdInsert.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = "inscripto";
                alumnoInscripcion.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar inscripcion del alumno", ex);
                throw ExcepcionManejada;
            }
        }

        public List<AlumnoInscripcion> GetAll()
        {
            try
            {
                List<AlumnoInscripcion> alumnoInscripciones = new List<AlumnoInscripcion>();

                this.OpenConnection();

                SqlCommand cmdAlumnoInscripcion = new SqlCommand("select * from alumnos_inscripciones", SqlConn);

                SqlDataReader drAlumnoInscripcion = cmdAlumnoInscripcion.ExecuteReader();

                while (drAlumnoInscripcion.Read())
                {
                    var a = new AlumnoInscripcion();

                    a.ID = (int)drAlumnoInscripcion["id_inscripcion"];
                    a.IDAlumno = (int)drAlumnoInscripcion["id_alumno"];
                    a.IDCurso = (int)drAlumnoInscripcion["id_curso"];
                    a.Condicion = (string)drAlumnoInscripcion["condicion"];
                    //a.nota=(int)drAlumnoInscripcion["nota"];

                    alumnoInscripciones.Add(a);
                }
                drAlumnoInscripcion.Close();
                this.CloseConnection();

                return alumnoInscripciones;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de inscripciones", ex);
                throw ExcepcionManejada;
            }
        }

        public List<AlumnoInscripcion> ObtenerDatosDeAlumnosInscriptosPorCurso(int idmateria, int idComision)
        {
            try
            {
                List<AlumnoInscripcion> alumnosPorComision = new List<AlumnoInscripcion>();
                this.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand("select per.id_persona, per.apellido , per.nombre , per.legajo from alumnos_inscripciones ai inner join personas per on ai.id_alumno = per.id_persona inner join cursos cur on cur.id_curso= ai.id_curso where per.tipo_persona = @tipoPersona and cur.id_materia = @idMateria and cur.id_comision = @idComision", SqlConn);
                sqlCommand.Parameters.Add("@tipoPersona", SqlDbType.Int, 50).Value = Persona.TipoPersonas.Alumno;
                sqlCommand.Parameters.Add("@idMateria", SqlDbType.Int, 50).Value = idmateria;
                sqlCommand.Parameters.Add("@idComision", SqlDbType.Int, 50).Value = idComision;
                SqlDataReader drAlumnoInscripcion = sqlCommand.ExecuteReader();
                while (drAlumnoInscripcion.Read())
                {
                    AlumnoInscripcion alumno = new AlumnoInscripcion();
                    alumno.ID = (int)drAlumnoInscripcion["id_inscripcion"];
                    alumno.Alumno = new Persona
                    {
                        ID = (int)drAlumnoInscripcion["id_persona"],
                        Apellido = (string)drAlumnoInscripcion["apellido"],
                        Nombre = (string)drAlumnoInscripcion["nombre"],
                    };
                    alumno.Nota = (int)drAlumnoInscripcion["nota"];
                    alumno.Condicion = (string)drAlumnoInscripcion["condicion"];

                    alumnosPorComision.Add(alumno);
                }

                drAlumnoInscripcion.Close();
                this.CloseConnection();

                return alumnosPorComision;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de inscripciones", ex);
                throw ExcepcionManejada;
            }
        }

        public void Update(AlumnoInscripcion alumno)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("Update alumnos_inscripciones set condicion=@condicion,nota=@nota" +
" where id_inscripcion = @id_inscripcion", SqlConn);
                cmdUpdate.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumno.Condicion;
                cmdUpdate.Parameters.Add("@nota", SqlDbType.Int, 50).Value = alumno.Nota;
                cmdUpdate.Parameters.Add("@id_inscripcion", SqlDbType.Int, 50).Value = alumno.ID;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la inscripcion del alumno", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<AlumnoInscripcion> GetAllByAlumno(Persona alumno)
        {
            List<AlumnoInscripcion> EstadoAlumno = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdGetAll = new SqlCommand("SELECT ai.condicion,isnull(ai.nota,0) 'nota',m.id_materia,m.desc_materia,p.id_plan,p.desc_plan,co.id_comision,co.desc_comision,esp.id_especialidad,esp.desc_especialidad from alumnos_inscripciones ai" +
" inner join cursos c on c.id_curso = ai.id_curso inner join materias m on m.id_materia = c.id_materia inner join comisiones co on co.id_comision = c.id_comision inner join planes p  on p.id_plan = co.id_plan " + "inner join especialidades esp on esp.id_especialidad = p.id_especialidad"
+ " where ai.id_alumno=@id_alumno", SqlConn);
                cmdGetAll.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumno.ID;
                SqlDataReader drAlumnoInscripcion = cmdGetAll.ExecuteReader();

                while (drAlumnoInscripcion.Read())
                {
                    AlumnoInscripcion alu = new AlumnoInscripcion();
                    alu.Condicion = (string)drAlumnoInscripcion["condicion"];
                    if ((int)drAlumnoInscripcion["nota"] != 0)
                    {
                        alu.Nota = (int)drAlumnoInscripcion["nota"];
                    }
                    else
                    {
                    }

                    alu.Curso = new Curso();

                    alu.Curso.Comision = new Comision
                    {
                        ID = (int)drAlumnoInscripcion["id_comision"],
                        Descripcion = (string)drAlumnoInscripcion["desc_comision"]
                    };

                    alu.Curso.Materia = new Materia
                    {
                        Descripcion = (string)drAlumnoInscripcion["desc_materia"]
                    };
                    alu.Curso.Materia.Plan = new Plan()
                    {
                        Descripcion = (string)drAlumnoInscripcion["desc_plan"]
                    };
                    alu.Curso.Materia.Plan.Especialidad = new Especialidad()
                    {
                        Descripcion = (string)drAlumnoInscripcion["desc_especialidad"]
                    };

                    EstadoAlumno.Add(alu);
                }
                drAlumnoInscripcion.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de alumno", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return EstadoAlumno;
        }

        public void Inscribir(AlumnoInscripcion alumnoInscripcion)
        {
            if (alumnoInscripcion.State == BusinessEntity.States.New)
            {
                this.Insert(alumnoInscripcion);
            }
        }
    }
}