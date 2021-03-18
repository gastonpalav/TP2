using Business.Entities;
using System.Collections.Generic;

namespace Data.Database
{
    public interface IAlumnoInscripcionAdapter
    {
        List<AlumnoInscripcion> GetAll();

        void Insert(AlumnoInscripcion alumnoInscripcion);

        void Inscribir(AlumnoInscripcion alumnoInscripcion);
    }
}