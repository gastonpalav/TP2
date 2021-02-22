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
    public class AlumnoInscripcionAdapter : Adapter
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



       

       

        

        public void Inscribir(AlumnoInscripcion alumnoInscripcion)
        {
            if (alumnoInscripcion.State == BusinessEntity.States.New)
            {
                this.Insert(alumnoInscripcion);
            }
            
        }
    }
}
