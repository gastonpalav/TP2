using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        #region Properties

        private Modoform _modo;

        public Modoform Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        #endregion

        #region Constants

        public enum Modoform
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        };

        #endregion

        public virtual void MapearDeDatos()
        {
        }

        public virtual void MapearADatos()
        {
        }

        public virtual void GuardarCambios()
        {
        }

        public virtual bool Validar()
        {
            return false;
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones,MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
    }
}