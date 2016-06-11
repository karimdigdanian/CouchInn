using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libCounchinn.Controles
{
    public partial class ucPestanias : UserControl
    {
        public ucPestanias()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.ucListarHospedajes1.Inicializar();
        }

        private void ucListarHospedajes1_VerDetalle(int ID_Publicacion)
        {
            this.ucVerDetalleHospedaje1.Inicializar(ID_Publicacion);
            this.ucVerDetalleHospedaje1.BringToFront();
        }

        private void ucVerDetalleHospedaje1_Load(object sender, EventArgs e)
        {

        }
    }
}
