using System;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private String _Condicion;

        public String Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }

        private Int64 _IDAlumno;

        public Int64 IDAlumno
        {
            get { return _IDAlumno; }
            set { _IDAlumno = value; }
        }

        private Int64 _IDCurso;

        public Int64 IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        private Int32 _Nota;

        public Int32 Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
    }
}