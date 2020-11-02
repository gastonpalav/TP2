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



        private Plan _plan;

        public Plan  Plan
        {
            get { return _plan; }
            set { _plan = value; }
        }


        private string _PlanDescripcion;

        public string PlanDescripcion
        {
            get { return Plan.Descripcion; }
            
        }

    }
}
