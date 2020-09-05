using System;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private Int32 _AnioCalendario;

        public Int32 AnioCalendario
        {
            get { return _AnioCalendario; }
            set { _AnioCalendario = value; }
        }

        private Int32 _Cupo;

        public Int32 Cupo
        {
            get { return _Cupo; }
            set { _Cupo = value; }
        }

        private String _Descripcion;

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private Comision _comision;

        public Comision Comision
        {
            get { return _comision; }
            set { _comision = value; }
        }

        private Materia _materia;

        public Materia Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }
    }
}