using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter alumnoInscripcionAdapter;
        private CursoAdapter cursoAdapter;

        public AlumnoInscripcionLogic()
        {
            this.alumnoInscripcionAdapter = new AlumnoInscripcionAdapter();
            this.cursoAdapter = new CursoAdapter();
        }

        public void Update(AlumnoInscripcion alumno)
        {
            try
            {
                alumnoInscripcionAdapter.Update(alumno);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar inscripcion del alumno", ex);
                throw ExcepcionManejada;
            }
        }

        public string Inscribir(AlumnoInscripcion inscripcion) //Aca cambio el retorno a string para indicar el estado de que el curso no tiene mas cupos -- 05/09/2022
        {
            try
            {
                List<AlumnoInscripcion> inscripciones = alumnoInscripcionAdapter.GetAll();
                foreach (var ins in inscripciones)
                {
                    if (ins.IDAlumno == inscripcion.IDAlumno && ins.IDCurso == inscripcion.IDCurso)
                    {
                        return "inscripto";
                    }
                }
                
                    alumnoInscripcionAdapter.Inscribir(inscripcion);
                    cursoAdapter.EliminarCupo((int)inscripcion.IDCurso);
                    return "permitido";
                
                
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al realizar inscripcion del alumno", ex);
                throw ExcepcionManejada;
            }
        }

        public List<AlumnoInscripcion> ObtenerDatosDeAlumnosInscriptosPorCurso(int idmateria, int idComision)
        {
            try
            {
                return alumnoInscripcionAdapter.ObtenerDatosDeAlumnosInscriptosPorCurso(idmateria, idComision);
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar inscripcion de alumnos", ex);
                throw ExcepcionManejada;
            }
        }

        public List<AlumnoInscripcion> GetAllByAlumno(Persona alumno)
        {
            try
            {
                return alumnoInscripcionAdapter.GetAllByAlumno(alumno);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar inscripcion de alumnos", ex);
                throw ExcepcionManejada;
            }
        }



    }
}