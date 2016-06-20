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
using MetroFramework.Controls;
using System.IO;

namespace libCounchinn.Controles
{
    public partial class ucVerMisReservas : UserControl
    {
        private ModeloLibCouchin VarModelo;

        private USUARIO cUsuario;

        private int id_publicacion;

        private PUBLICACION cPublicacion;

        public ucVerMisReservas()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.VarModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.bindingSourceVer_MisReservas.DataSource = this.VarModelo.SEL_VERMISRESERVAS(2);//ElUsuarioLogeado.Retorna_Id_Usuario);
            this.metroGrid1.DataSource = bindingSourceVer_MisReservas;
            //if (this.bindingSourceVer_MisReservas.Count != 0)
            //{
            //    id_publicacion = Convert.ToInt32(metroGrid1[1, 0].Value.ToString());
            //    estadoDeBotones(true);
            //}
            //else
            //{
            //    estadoDeBotones(false);
            //}
        }

        private void estadoDeBotones(bool estado)
        {
            if (estado)
            {
                this.mbAtras.Enabled = true;
                this.mbCancelarReserva.Enabled = true;
                this.mbModificar.Enabled = true;
                this.mbVer.Enabled = true;
            }
            else
            {
                this.mbAtras.Enabled = false;
                this.mbCancelarReserva.Enabled = false;
                this.mbModificar.Enabled = false;
                this.mbVer.Enabled = false;
            }
        }

        private void mbAtras_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void mbVer_Click(object sender, EventArgs e)
        {
            this.metroGrid1.SendToBack();
            this.ucAltaPublicacion1.Enabled = false; // cambiar por metodo
            this.ucAltaPublicacion1.InicializarModificacion(id_publicacion);
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_publicacion = Convert.ToInt32(metroGrid1[1, metroGrid1.CurrentCell.RowIndex].Value.ToString());
        }
    }
}
