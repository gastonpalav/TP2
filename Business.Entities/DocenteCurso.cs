using System;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private TiposCargos _Cargo;

        public TiposCargos Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        private Int64 _IDCurso;

        public Int64 IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        private Curso _curso;

        public Curso Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        

        public string MateriaDescripcion
        {
            get { return Curso.Materia.Descripcion; }

        }

        private AlumnoInscripcion _alumnoInscripcion;

        public AlumnoInscripcion AlumnoInscripcion
        {
            get { return _alumnoInscripcion; }
            set { _alumnoInscripcion = value; }
        }




        private Int64 _IDDocente;

        public Int64 IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }

        public enum TiposCargos
        {
            titular,
            auxiliar
        };
    }
}