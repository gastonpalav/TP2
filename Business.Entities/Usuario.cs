using System;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private String _NombreUsuario;

        public String NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        private String _Clave;

        public String Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        private String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private String _Apellido;

        public String Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private String _Email;

        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private Boolean _Habilitado;

        public Boolean Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        private Persona _Persona;

        public Persona Persona
        {
            get { return _Persona; }
            set { _Persona = value; }
        }

        public int LegajoPersona
        {
            get { return Persona.Legajo; }
        }
    } 
}