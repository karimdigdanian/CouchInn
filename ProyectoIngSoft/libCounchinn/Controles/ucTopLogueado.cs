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
    public partial class ucTopLogueado : UserControl
    {
        public event DelegadoLogin CerrarSesion;

        public event DelegadoLogin Administrar;

        public event DelegadoLogin VerCuenta;

        public event DelegadoLogin AdministrarMisPublicaciones;

        public ucTopLogueado()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            if (ElUsuarioLogeado.UsuarioLogeado != null)
            {
                this.metroLink1.Text = ElUsuarioLogeado.UsuarioLogeado.NOMRE_USUARIO;
                this.Visible = true;
                this.BringToFront();
            }
            else
            {
                this.Visible = false ;
                this.SendToBack();
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

            if (ElUsuarioLogeado.UsuarioLogeado.TIPO_USUARIO == 4)
            {
                this.metroLink1.ContextMenuStrip = this.contextMenuStrip2;
                this.contextMenuStrip2.Show(this.metroLink1, 0, 110);
            }
            else
            {
                this.metroLink1.ContextMenuStrip = this.contextMenuStrip1;
                this.contextMenuStrip1.Show(this.metroLink1, 0, 110);
            }
            
        }

        private void opcionCerrarSesion_Click(object sender, EventArgs e)
        {
            if (this.CerrarSesion != null)
            {
                this.CerrarSesion();
            }
        }

        private void tiposDeHospedajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Administrar != null)
            {
                this.Administrar();
            }
        }

        private void opcionMiCuenta_Click(object sender, EventArgs e)
        {
            if (this.VerCuenta != null)
            {
                this.VerCuenta();
            }
        }

        private void misToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.AdministrarMisPublicaciones != null)
            {
                this.AdministrarMisPublicaciones();
            }
        }
    }
}
