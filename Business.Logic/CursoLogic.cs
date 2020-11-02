using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        private CursoAdapter CursoData;

        public CursoLogic()
        {
            this.CursoData = new CursoAdapter();
        }

        public Curso GetOne(int idCurso)
        {
            return this.CursoData.GetOne(idCurso);
        }

        public List<Curso> GetAll()
        {
            try
            {
                return this.CursoData.GetAll();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Curso curso)
        {
            this.CursoData.Save(curso);
        }

        public void Delete(int idCurso)
        {
            this.CursoData.Delete(idCurso);
        }

        public List<Curso> BuscarComisionesPorMateria(string materia)
        {
            return this.CursoData.BuscarComisionesPorMateria(materia);
        }
    }
}