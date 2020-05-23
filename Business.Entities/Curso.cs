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

        private Int64 _IDComision;

        public Int64 IDComision
        {
            get { return _IDComision; }
            set { _IDComision = value; }
        }

        private Int64 _IDMateria;

        public Int64 IDMateria
        {
            get { return _IDMateria; }
            set { _IDMateria = value; }
        }
    }
}