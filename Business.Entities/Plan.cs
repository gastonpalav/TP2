using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
		private String _Descripcion;

		public String Descripcion
		{
			get { return _Descripcion; }
			set { _Descripcion = value; }
		}

        private Especialidad _Especialidad;

        public Especialidad Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value; }
        }

        private string _EspecialidadDescripcion;

        public string EspecialidadDescripcion
        {
            get { return Especialidad.Descripcion; }
            set { _EspecialidadDescripcion = value; }
        }





    }
}
