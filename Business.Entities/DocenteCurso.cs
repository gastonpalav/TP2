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

        private Int64 _IDDocente;

        public Int64 IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }

        public enum TiposCargos
        {
        };
    }
}