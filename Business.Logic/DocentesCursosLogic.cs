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
            try
            {
                this.docenteCursoAdapter.Save(dc);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar docente curso", ex);
                throw ExcepcionManejada;
            }
            
        }
        public DocenteCurso GetOneD(int ID)
        {
            try
            {
                //para el abm de docentecurso
                return docenteCursoAdapter.GetOneD(ID);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar docenteCurso", ex);
                throw ExcepcionManejada;
            }
            
        }

        public DocenteCurso GetOne(int ID)
        {
            try
            {
                return docenteCursoAdapter.GetOne(ID);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar docenteCurso", ex);
                throw ExcepcionManejada;
            }
            
        }

        public List<DocenteCurso> GetAllByDocente(Persona docente)
        {
            try
            {
                return docenteCursoAdapter.GetAllbyDocente(docente);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista", ex);
                throw;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                this.docenteCursoAdapter.Delete(id);

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar docenteCurso", ex);
                throw ExcepcionManejada;
            }
        }

        public List<DocenteCurso> GetAll()
        {
            try
            {
                return docenteCursoAdapter.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista", ex);
                throw ExcepcionManejada;
            }
            
        }



    }
}
