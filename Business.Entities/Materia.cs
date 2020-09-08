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

		private Plan _Plan;

		public Plan Plan
		{
			get { return _Plan; }
			set { _Plan = value; }
		}

        //private string _planDescripcion;

        public string PlanDescripcion
        {
            get { return Plan.Descripcion; }
            //set { _planDescripcion = value; }
        }





    }
}
