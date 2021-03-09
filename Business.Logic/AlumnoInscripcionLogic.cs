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
            alumnoInscripcionAdapter.Update(alumno);
        }


        public bool Inscribir(AlumnoInscripcion inscripcion)
        {
            try
            {
                List<AlumnoInscripcion> inscripciones=alumnoInscripcionAdapter.GetAll();
                foreach(var ins in inscripciones)
                {
                    if(ins.IDAlumno==inscripcion.IDAlumno && ins.IDCurso==inscripcion.IDCurso)
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
                throw ex;
            }
        }

        public List<AlumnoInscripcion> GetAllByAlumno(Persona alumno)
        {
            return alumnoInscripcionAdapter.GetAllByAlumno(alumno);
        }
    }
}