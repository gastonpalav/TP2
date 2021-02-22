using Business.Entities;
using Data.Database;
using System;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter alumnoInscripcionAdapter;

        public AlumnoInscripcionLogic()
        {
            this.alumnoInscripcionAdapter = new AlumnoInscripcionAdapter();
        }
        public void Inscribir(AlumnoInscripcion inscripcion)
        {
            try
            {
                alumnoInscripcionAdapter.Inscribir(inscripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}