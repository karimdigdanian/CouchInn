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
using MetroFramework.Controls;

namespace libCounchinn.Controles
{
    public partial class usContribucion : MetroUserControl
    {

        #region Variables

        private ModeloLibCouchin varModelo;

        public event DelegadoLogin ContribucionRealizada;

        #endregion

        #region Inicializar

        public usContribucion()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
        }

        #endregion

        #region Eventos Privados

        private void mtxtbNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (this.mtxtbNumeroTarjeta.Text.Length == 4)
            {
                this.mtxtbNumeroTarjeta.Text += "-";
                this.mtxtbNumeroTarjeta.Select(this.mtxtbNumeroTarjeta.Text.Length, 0);
            }
            else
            {
                if (this.mtxtbNumeroTarjeta.Text.Length == 9)
                {
                    this.mtxtbNumeroTarjeta.Text += "-";
                    this.mtxtbNumeroTarjeta.Select(this.mtxtbNumeroTarjeta.Text.Length, 0);
                }
                else
                {
                    if (this.mtxtbNumeroTarjeta.Text.Length == 14)
                    {
                        this.mtxtbNumeroTarjeta.Text += "-";
                        this.mtxtbNumeroTarjeta.Select(this.mtxtbNumeroTarjeta.Text.Length, 0);
                    }
                }
            }
        }

        private void mtxtboxVencTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (this.mtxtboxVencTarjeta.Text.Length == 2)
            {
                this.mtxtboxVencTarjeta.Text += "/";
                this.mtxtboxVencTarjeta.Select(this.mtxtboxVencTarjeta.Text.Length, 0);
            }
        }

        private void mbtAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.bindingSourceContribucion.DataSource = this.varModelo.INS_CONTRIBUCIONES_USUARIO(ElUsuarioLogeado.UsuarioLogeado.ID_USUARIO, this.mtxtbMonto.Text, DateTime.Now);
                    MessageBox.Show("Se ha realizado la contribucion al sitio.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.SendToBack();
                    if (this.ContribucionRealizada != null)
                    {
                        this.ContribucionRealizada();
                    }
                }
                else
                {
                    MessageBox.Show("Para realizar la operacion debe completar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch 
            {
                MessageBox.Show("Se a producido un error durante la operacion de contribucion al sitio, vuelva a internarlo mas tarde.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void mbtCancelar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private bool ValidarCampos()
        {
            if ((this.mtxtbTitularTarjeta.Text == "") || (this.mtxtboxCodSeguridad.Text == "") || (this.mtxtboxVencTarjeta.Text == "") || (this.mtxtbNumeroTarjeta.Text == "") || (this.mtxtbMonto.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
