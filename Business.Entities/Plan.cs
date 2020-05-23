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

		private Int64 _IDEspecialidad;

		public Int64 IDEspecialidad
		{
			get { return _IDEspecialidad; }
			set { _IDEspecialidad = value; }
		}




	}
}
