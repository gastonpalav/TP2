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

        public bool Inscribir(AlumnoInscripcion inscripcion)
        {
            try
            {
                List<AlumnoInscripcion> inscripciones = alumnoInscripcionAdapter.GetAll();
                foreach (var ins in inscripciones)
                {
                    if (ins.IDAlumno == inscripcion.IDAlumno && ins.IDCurso == inscripcion.IDCurso)
                    {
                        return false;
                    }
                }

                alumnoInscripcionAdapter.Inscribir(inscripcion);
                cursoAdapter.EliminarCupo((int)inscripcion.IDCurso);
                return true;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al inscribir inscripcion del alumno", ex);
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