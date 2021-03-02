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

       

        private Curso _curso;

        public Curso  Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

       

        



        public string MateriaDescripcion
        {
            get { return Curso.Materia.Descripcion; }

        }



        public string ComisionDescripcion
        {
            get { return Curso.Comision.Descripcion; }

        }

        public string PlanDescripcion
        {
            get { return Curso.Materia.Plan.Descripcion; }
        }


       public string EspecialidadDescripcion
        {
            get { return Curso.Materia.Plan.Especialidad.Descripcion; }
        }



        private Int32 _Nota;

        public Int32 Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
    }
}