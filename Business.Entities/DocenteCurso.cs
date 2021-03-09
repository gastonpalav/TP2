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

        //private Int64 _IDCurso;

        //public Int64 IDCurso
        //{
        //    get { return _IDCurso; }
        //    set { _IDCurso = value; }
        //}

        //private Int64 _IDDocente;

        //public Int64 IDDocente
        //{
        //    get { return _IDDocente; }
        //    set { _IDDocente = value; }


        private Persona _docente;

        public Persona Docente
        {
            get { return _docente; }
            set { _docente = value; }
        }

        private Curso _curso;

        public Curso Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        public int LegajoDocente
        {
            get { return Docente.Legajo; }

        }

        private AlumnoInscripcion _alumnoInscripcion;

        public AlumnoInscripcion AlumnoInscripcion
        {
            get
            {
                return _alumnoInscripcion;
            }

            set
            {
                _alumnoInscripcion = value;
            }
        }



        public int LegajoAlumno
        {
            get { return AlumnoInscripcion.Alumno.Legajo; }

        }



        public string AlumnoCondicion
        {
            get { return AlumnoInscripcion.Condicion; }

        }



        public int AlumnoNota
        {
            get { return AlumnoInscripcion.Nota; }

        }

        public int AlumnoInscripcionID
        {
            get { return AlumnoInscripcion.ID; }
        }

       






        public string CursoDescripcion
        {
            get { return Curso.MateriaDescripcion +" "+ Curso.ComisionDescripcion; }

        }

        public enum TiposCargos
        {
            Titular,
            Auxiliar
        };
    }
}