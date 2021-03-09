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
    public class DocentesCursosLogic : BusinessLogic
    {
        private DocenteCursoAdapter docenteCursoAdapter;
        public DocentesCursosLogic()
        {
            this.docenteCursoAdapter = new DocenteCursoAdapter();


        }

        public void Save(DocenteCurso dc)
        {
            this.docenteCursoAdapter.Save(dc);
        }
        public DocenteCurso GetOne(int ID)
        {
            return docenteCursoAdapter.GetOne(ID);
        }


        public List<DocenteCurso> GetAllByDocente(Persona docente)
        {
            return docenteCursoAdapter.GetAllbyDocente(docente);
        }


    }
}
