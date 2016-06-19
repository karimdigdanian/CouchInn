using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCounchinn.Clases;

namespace libCounchinn.Controles
{
    public partial class ucPestanias : UserControl
    {
        #region Variables

        public event EventoClickOperacion EventoMostrarMisPublicaciones; 

        #endregion


        public ucPestanias()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.ucAltaPublicacion1.Inicializar();
            this.ucListarHospedajes1.Inicializar();
            this.metroTabControl1.SelectedIndex = 0;
            this.ucListarHospedajes1.BringToFront();
        }

        private void ucListarHospedajes1_VerDetalle(int ID_Publicacion)
        {
            this.ucVerDetalleHospedaje1.Inicializar(ID_Publicacion);
            this.ucAltaPublicacion1.id = ID_Publicacion;
            this.ucVerDetalleHospedaje1.BringToFront();
        }

        private void ucVerDetalleHospedaje1_Load(object sender, EventArgs e)
        {

        }
        private void EventoMisHospedajes()
        {
            if (this.EventoMostrarMisPublicaciones != null)
            {
                this.ucMisHospedajes1.Inicializar();
                this.EventoMostrarMisPublicaciones();
            }
        }

        private void ucAltaPublicacion1_AltadePublicacionRealizada()
        {
            metroTabControl1.SelectedIndex = 0;
        }
    }
}
