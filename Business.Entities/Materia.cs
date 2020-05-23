using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia: BusinessEntity
    {
		private String _Descripcion;

		public String Descripcion
		{
			get { return _Descripcion; }
			set { _Descripcion = value; }
		}

		private Int32 _HSSemanales;

		public Int32 HSSemanales
		{
			get { return _HSSemanales; }
			set { _HSSemanales = value; }
		}

		private Int32 _HSTotales;

		public Int32 HSTotales
		{
			get { return _HSTotales; }
			set { _HSTotales = value; }
		}

		private Int64 _IDPlan;

		public Int64 IDPlan
		{
			get { return _IDPlan; }
			set { _IDPlan = value; }
		}






	}
}
