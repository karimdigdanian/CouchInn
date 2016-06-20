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
    public partial class ucOlvideContraseña : UserControl
    {
        #region Variables

        public event DelegadoLogin Volver;

        private ModeloLibCouchin varModelo;

        #endregion

        #region Inicializar

        public ucOlvideContraseña()
        {
            InitializeComponent();
        }

        public void Inicilizar()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
        }

        #endregion

        #region Eventos Privados

        private void mbtEnviarNuevaContreseña_Click(object sender, EventArgs e)
        {
            string StEmail = this.varModelo.SelectEmailUsuario(this.mTxtOlvide.Text);
            if (StEmail != null && StEmail != "Usuario Bloqueado")
            {
                #region Generacion Nueva Contraseña
                Random obj = new Random();
                string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                int longitud = posibles.Length;
                char letra;
                int longitudnuevacadena = 8;
                string nuevacadena = "";
                for (int i = 0; i < longitudnuevacadena; i++)
                {
                    letra = posibles[obj.Next(longitud)];
                    nuevacadena += letra.ToString();
                }
                #endregion
                libcCouchin.Clases.Correo CorreoRecuperacion = new libcCouchin.Clases.Correo();
                CorreoRecuperacion.enviarCorreo(nuevacadena, StEmail);
                USUARIO us = varModelo.SelectUsuarioxNombreUsuario(this.mTxtOlvide.Text);
                this.bindingSourceActualizaContraseña.DataSource = this.varModelo.UPD_ACTUALIZAR_CONTRASENA(us.ID_USUARIO, nuevacadena);
                
            }
            else
            {
                if (StEmail != null)
                {
                    MessageBox.Show("El usuario ingresado se encuentra bloquedo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no es valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (this.Volver != null)
            {
                this.Visible = false;
                this.SendToBack();
                this.Volver();
            }
        }
    }
}
