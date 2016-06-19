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
    public partial class ucMisHospedajes : UserControl
    {
        private ModeloLibCouchin VarModelo;

        private USUARIO cUsuario;

        private int id_publicacion;

        private PUBLICACION cPublicacion;

        public ucMisHospedajes()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.VarModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.bindingSourceSel_MisHospedajes.DataSource = this.VarModelo.SEL_MIS_HOSPEDAJES(2);//ElUsuarioLogeado.Retorna_Id_Usuario);
            this.metroGrid1.DataSource = bindingSourceSel_MisHospedajes;
            this.metroGrid1.Columns[0].Visible = false;
            this.metroGrid1.Columns[1].Visible = false;
            this.metroGrid1.Columns[3].Visible = false;
            this.metroGrid1.BringToFront();
            if (this.bindingSourceSel_MisHospedajes.Count != 0)
            {
                id_publicacion = Convert.ToInt32(metroGrid1[1, 0].Value.ToString());
                estadoDeBotones(true);
            }
            else
            {
                estadoDeBotones(false);
            }
        }

        private void mbModificar_Click_1(object sender, EventArgs e)
        {
            this.ucAltaPublicacion1.InicializarModificacion(Convert.ToInt32(this.metroGrid1[1, this.metroGrid1.CurrentCell.RowIndex].Value.ToString()));
            this.ucAltaPublicacion1.BringToFront();
        }

        private void mbAtras_Click(object sender, EventArgs e)
        {
            this.ucAltaPublicacion1.SendToBack();
            this.metroGrid1.BringToFront();
            this.bindingSourceSel_MisHospedajes.DataSource = this.VarModelo.SEL_MIS_HOSPEDAJES(ElUsuarioLogeado.Retorna_Id_Usuario);

        }

        private void mbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la publicacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                cPublicacion = this.VarModelo.SelectPublicacionXId(id_publicacion);
                this.bindingSourceSel_MisHospedajes.DataSource = this.VarModelo.UPD_PUBLICACION(this.cPublicacion.ID_PUBLICACION, this.cPublicacion.TITULO_PUBLICACION, this.cPublicacion.FECHA_INICIO, this.cPublicacion.FECHA_FIN, this.cPublicacion.DESCRIPCION_PUBLICACION, this.cPublicacion.CANT_PERSONAS, this.cPublicacion.TIPO_HOSPEDAJE, false,this.cPublicacion.FOTO_PRINCIPAL);
            }
            Inicializar();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_publicacion = Convert.ToInt32(metroGrid1[1, metroGrid1.CurrentCell.RowIndex].Value.ToString());
        }

        private void estadoDeBotones(bool estado)
        {
            if (estado)
            {
                this.mbAtras.Enabled = true;
                this.mbEliminar.Enabled = true;
                this.mbModificar.Enabled = true;
                this.mbVerPub.Enabled = true;
            }
            else
            {
                this.mbAtras.Enabled = false;
                this.mbEliminar.Enabled = false;
                this.mbModificar.Enabled = false;
                this.mbVerPub.Enabled = false;
            }
        }
    }
}
