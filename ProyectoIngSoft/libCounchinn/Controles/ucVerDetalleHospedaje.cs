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
    public partial class ucVerDetalleHospedaje : UserControl
    {
        private ModeloLibCouchin VarModelo;

        public ucVerDetalleHospedaje()
        {
            InitializeComponent();
        }

        public void Inicializar(int idpublicacion)
        {
            this.VarModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.bindingSourceSELDETALLE.DataSource = this.VarModelo.SEL_VERDETALLESHOSPEDAJE(idpublicacion);
            this.bindingSourceSELDETALLE.EndEdit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
