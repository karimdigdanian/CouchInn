using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCounchinn.Modelo;
using libCounchinn.Clases;

namespace libCounchinn.Controles
{
    public partial class ucVerTipoHospedaje : UserControl
    {

        #region variables

        private ModeloLibCouchin varModelo;

        #endregion

        public ucVerTipoHospedaje()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.bindingSelHospedaje.DataSource = this.varModelo.SEL_TIPOHOSPEDAJE(true);
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mbtAceptar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }
    }
}