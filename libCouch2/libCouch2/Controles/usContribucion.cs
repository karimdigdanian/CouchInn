using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCouch2.Modelo;
using libCouch2.Clases;
using MetroFramework.Controls;

namespace libCouch2.Controles
{
    public partial class usContribucion : MetroUserControl
    {

        #region Variables

        private BD_MODELO_COUCHIN_Var varModelo;

        #endregion

        #region Propiedades del control de usuario

        private USUARIO _usuario;
        public USUARIO Usuario
        {
            get
            {
                return this._usuario;
            }
            set
            {
                this._usuario = value;
            }
        }

        #endregion

        #region Inicializar

        public usContribucion()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.varModelo = new BD_MODELO_COUCHIN_Var(ClaseDeConfiguracion.EFConnectionString);
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
                this.bindingSourceContribucion.DataSource = this.varModelo.INS_CONTRIBUCIONES_USUARIO(this._usuario.ID_USUARIO, this.mtxtbMonto.Text, DateTime.Now);
                MessageBox.Show("Se a realizado la contribucion al sitio /n Gracias por elegirnos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Se a producido un error durante la operacion de contribucion al sitio, vuelva a internarlo mas tarde.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
