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
using libCounchinn.Modelo;

namespace libCounchinn.Controles
{
    public partial class ucListarHospedajes : UserControl
    {
        private ModeloLibCouchin VarModelo;
        private bool log;
        public event DelegadoVerDetalle VerDetalle;

        public ucListarHospedajes()
        {
            InitializeComponent();

        }

        public void Inicializar()
        {
            mCBFiltro.SelectedIndex = 0;
            if (ElUsuarioLogeado.UsuarioLogeado != null)
            {
                log = true;
            }
            else
            {
                log = false;
            }
            try
            {
                this.VarModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
                this.bindingSourceListarHospedajes.DataSource = this.VarModelo.SEL_IMAGENESPUBLICACION();
            }
            catch 
            {

            }

        }

        private void dataRepeater1_ItemTemplate_Click(object sender, EventArgs e)
        {
           int idPub =  Convert.ToInt32(dataRepeater1.CurrentItem.Controls["mlbIdPublicacion"].Text);
            if (this.VerDetalle !=  null)
            {
                this.SendToBack();
                this.VerDetalle(idPub);
            }
        }

        private void dataRepeater1_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            if (log)
            {
                MetroFramework.Controls.MetroLink lin = (e.DataRepeaterItem.Controls["metroLink1"] as MetroFramework.Controls.MetroLink);
                lin.Visible = true;
                e.DataRepeaterItem.Controls.Add(lin);
            }
            else
            {
                MetroFramework.Controls.MetroLink lin = (e.DataRepeaterItem.Controls["metroLink1"] as MetroFramework.Controls.MetroLink);
                lin.Visible = false;
                e.DataRepeaterItem.Controls.Add(lin);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.dataRepeater1.Focus();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.dataRepeater1.Focus();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void desaparecer()
        {
            if (mLabelTitulo.Visible == true)
            {
                mLabelTitulo.Visible = false;
                mTBTitulo.Visible = false;
                return;
            }
            if (mLabelTipo.Visible == true)
            {
                mLabelTipo.Visible = false;
                mCBTipo.Visible = false;
                return;
            }
            if (mLabelLugar.Visible == true)
            {
                mLabelLugar.Visible = false;
                mCBLugar.Visible = false;
                mLabelCiudad.Visible = false;
                mTBCiudad.Visible = false;
                return;
            }
            if (mLabelCapacidad.Visible == true)
            {
                mLabelCapacidad.Visible = false;
                mTBCapacidad.Visible = false;
                return;
            }
            if (mLabelFechaInicio.Visible == true)
            {
                mLabelFechaInicio.Visible = false;
                mLabelFechaFin.Visible = false;
                mCBFechaInicio.Visible = false;
                mCBFechaFin.Visible = false;
                return;
            }
        }

        private void mostrar(int indice)
        {
            desaparecer();
            switch (indice)
            {
                case 1:
                    mLabelTitulo.Visible = true;
                    mTBTitulo.Visible = true;
                    break;
                case 2:
                    mLabelTipo.Visible = true;
                    mCBTipo.Visible = true;
                    break;
                case 3:
                    mLabelLugar.Visible = true;
                    mCBLugar.Visible = true;
                    mLabelCiudad.Visible = true;
                    mTBCiudad.Visible = true;
                    break;
                case 4:
                    mLabelCapacidad.Visible = true;
                    mTBCapacidad.Visible = true;
                    break;
                case 5:
                    mLabelFechaInicio.Visible = true;
                    mLabelFechaFin.Visible = true;
                    mCBFechaInicio.Visible = true;
                    mCBFechaFin.Visible = true;
                    break;
            }

        }

        private void mCBFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar(mCBFiltro.SelectedIndex);
        }

        private void mBtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
