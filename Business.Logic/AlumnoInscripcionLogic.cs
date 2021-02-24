using Business.Entities;
using Data.Database;
using System;

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
        public void Inscribir(AlumnoInscripcion inscripcion)
        {
            try
            {
                alumnoInscripcionAdapter.Inscribir(inscripcion);
                cursoAdapter.EliminarCupo((int)inscripcion.IDCurso);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}