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
    public partial class ucAltaTipoHospedaje : UserControl
    {

        #region variables

        private ModeloLibCouchin varModelo;

        private int ID_Tabla;

        #endregion

        #region Inicializar

        public ucAltaTipoHospedaje()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.bindingSourceSelTiposHospedajes.DataSource = this.varModelo.SEL_TIPOHOSPEDAJE(true);
        }

        #endregion

        #region Eventos Privados
        private void mbtCargarHospedaje_Click(object sender, EventArgs e)
        {
            if (this.mTxtHospedaje.Text.Length != 0)
            {

                if (this.mbtCargarHospedaje.Text == "Cargar")
                {
                    string EstadoTipoIngresado = this.varModelo.EstadoTipoHospedaje(this.mTxtHospedaje.Text);
                    switch (EstadoTipoIngresado)
                    {
                        case "NoExiste":
                            if (this.mTxtHospedaje.Text == "")
                            {
                                MessageBox.Show("El campo ingresado no es valido", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            this.bindingSourceINSERT_Hosp.DataSource = this.varModelo.INS_TIPOHOSPEDAJE(this.mTxtHospedaje.Text);
                            MessageBox.Show("Alta de hospedaje satisfactoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.mTxtHospedaje.Text = "";
                            break;
                        case "Baja":
                            TIPO_HOSPEDAJE t = this.varModelo.SelectTipoHospedajeXtipoHospeDescripion(this.mTxtHospedaje.Text);
                            this.bindingSourceUDPTipoHospedaje.DataSource = this.varModelo.UPD_TIPO_HOSPEDAJE(t.ID_TIPO_HOSPEDAJE, t.DESCRIPCION, true);
                            MessageBox.Show("Alta de hospedaje satisfactoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.mTxtHospedaje.Text = "";
                            break;
                        default: //estado Activo
                            MessageBox.Show("El tipo hospedaje realizado ya se encuentra cargado");
                            break;
                    }
                }
                else
                {
                    this.bindingSourceUDPTipoHospedaje.DataSource = this.varModelo.UPD_TIPO_HOSPEDAJE(ID_Tabla, this.mTxtHospedaje.Text, true);
                    this.mbtCargarHospedaje.Text = "Cargar";

                }
                this.inicializar();
            }
            else
            {
                MessageBox.Show("El campo de hospedaje se encuentra en blanco, para realizar la operacion complete el campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mTxtHospedaje.Focus();
            }

        }

        private void mbtModificar_Click(object sender, EventArgs e)
        {
            this.mTxtHospedaje.Text = metroGridAltaHospedaje[0, metroGridAltaHospedaje.CurrentCell.RowIndex].Value.ToString();
            ID_Tabla = Convert.ToInt32(metroGridAltaHospedaje[1, metroGridAltaHospedaje.CurrentCell.RowIndex].Value.ToString());
            this.mbtCargarHospedaje.Text = "Aceptar";
        }

        private void mbtEliminar_Click(object sender, EventArgs e)
        {
            this.mTxtHospedaje.Text = metroGridAltaHospedaje[0, metroGridAltaHospedaje.CurrentCell.RowIndex].Value.ToString();
            TIPO_HOSPEDAJE t = this.varModelo.SelectTipoHospedajeXtipoHospeDescripion(this.mTxtHospedaje.Text);
            this.bindingSourceUDPTipoHospedaje.DataSource = this.varModelo.UPD_TIPO_HOSPEDAJE(t.ID_TIPO_HOSPEDAJE, t.DESCRIPCION, false);
            this.inicializar();
            this.mTxtHospedaje.Text = "";
        }

        private void mbtCancelarHospedaje_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
        #endregion
    }
}
