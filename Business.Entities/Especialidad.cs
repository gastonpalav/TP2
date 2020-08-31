using System;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        private String _Descripcion;

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
    }
}