using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
    public class DocenteCursosLogic : BusinessLogic
    {
        private DocentesCursosAdapter DocentesCursosAdapter;
        public DocenteCursosLogic()
        {
            this.DocentesCursosAdapter = new DocentesCursosAdapter();
          

        }


        public List<DocenteCurso> GetAllByDocente(Persona docente)
        {
            return DocentesCursosAdapter.GetAllByDocente(docente);
        }


    }
}
