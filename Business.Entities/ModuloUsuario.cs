using System;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private Int64 _IDUsuario;

        public Int64 IDusuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        private Int64 _IDModulo;

        public Int64 IdModulo
        {
            get { return _IDModulo; }
            set { _IDModulo = value; }
        }

        private Boolean _PermiteAlta;

        public Boolean PermiteAlta
        {
            get { return _PermiteAlta; }
            set { _PermiteAlta = value; }
        }

        private Boolean _PermiteBaja;

        public Boolean PermiteBaja
        {
            get { return _PermiteBaja; }
            set { _PermiteBaja = value; }
        }

        private Boolean _PermiteModificacion;

        public Boolean PermiteModificacion
        {
            get { return _PermiteModificacion; }
            set { _PermiteModificacion = value; }
        }

        private Boolean _PermiteConsulta;

        public Boolean PermiteConsulta
        {
            get { return _PermiteConsulta; }
            set { _PermiteConsulta = value; }
        }
    }
}