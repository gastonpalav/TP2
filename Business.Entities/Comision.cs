using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
		private Int32 _AnioEspecialidad;

		public Int32 AnioEspecialidad
		{
			get { return _AnioEspecialidad; }
			set { _AnioEspecialidad = value; }
		}

		private String _Descripcion;

		public String Descripcion
		{
			get { return _Descripcion; }
			set { _Descripcion = value; }
		}

		private Int64 _IDPlan;

		public Int64 IDPlan
		{
			get { return _IDPlan; }
			set { _IDPlan = value; }
		}


	}
}
