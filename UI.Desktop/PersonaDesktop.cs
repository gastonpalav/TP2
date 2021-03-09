using Business.Entities;
using Business.Logic;
using System;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {

        /// <summary>
        /// NO VA?
        /// </summary>
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        public PersonaDesktop(Modoform modo) : this()
        {
            this.Modo = modo;
            this.GetAllPlanes();
        }

        public PersonaDesktop(int ID, Modoform modo) : this()
        {
            PersonaLogic per = new PersonaLogic();
            this.GetAllPlanes();
            var PersonaActual = per.GetOneById(ID);
            this.Modo = modo;
            MapearDeDatos();
        }

        public Persona PersonaActual { get; set; }

        private void GetAllPlanes()
        {
            throw new NotImplementedException();
        }
    }
}