using System;

namespace Business.Entities
{
    public class Personas : BusinessEntity
    {
        private String _Apellido;

        public String Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private String _Direccion;

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        private String _Email;

        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private DateTime _FechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        private Int64 _IDPlan;

        public Int64 IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
        }

        private Int32 _Legajo;

        public Int32 Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }

        private String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private String _Telefono;

        public String Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        private TipoPersonas _TipoPersona;

        public TipoPersonas TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }

        public enum TipoPersonas
        {
        };
    }
}