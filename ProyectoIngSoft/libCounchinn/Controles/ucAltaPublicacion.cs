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
using System.IO;

namespace libCounchinn.Controles
{
    public partial class ucAltaPublicacion : MetroFramework.Controls.MetroUserControl
    {
        #region Variables

        private ModeloLibCouchin varModelo;

        private USUARIO cUsuario;

        private PERSONA cPersona;

        private DIRECCION cDireccion;

        private PUBLICACION cPublicacion;

        public event DelegadoLogin AltadePublicacionRealizada;

        private bool EsModificacion = false;

        #endregion

        #region Inicializar

        public ucAltaPublicacion()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            if (ElUsuarioLogeado.UsuarioLogeado != null)
            {
                this.varModelo.CargarMetroComboTablas(ref this.mcbPaisAltaPub, "03");
                this.varModelo.CargarMetroComboTablas(ref this.mcbProvAltaPub, "05");
                this.varModelo.CargarMetroComboTiposHospedaje(ref this.mcbTipoHospAltaPub);
                this.cUsuario = this.varModelo.SelectUsuarioXid(ElUsuarioLogeado.Retorna_Id_Usuario);
                this.cPersona = this.varModelo.SelectPersonaXid(ElUsuarioLogeado.Retorna_Id_Persona);
                this.cDireccion = this.varModelo.SelectDireccionXID((int)cPersona.UBICACION);
                this.mcbProvAltaPub.SelectedValue = "52";
                this.mcbPaisAltaPub.SelectedValue = "8";
                this.mtbCiudadAltaPub.Text = "";
                this.EsModificacion = false;
            }
        }

        public void InicializarModificacion(int id_publicacion)
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.varModelo.CargarMetroComboTablas(ref this.mcbPaisAltaPub, "03");
            this.varModelo.CargarMetroComboTablas(ref this.mcbProvAltaPub, "05");
            this.varModelo.CargarMetroComboTiposHospedaje(ref this.mcbTipoHospAltaPub);
            this.cPublicacion = this.varModelo.SelectPublicacionXId(id_publicacion);
            this.cDireccion = this.varModelo.SelectDireccionXID((int) cPublicacion.ID_DIRECCION);
            this.EsModificacion = true;
            this.CargarPublicacion();


        }

        private void CargarPublicacion()
        {
            this.metroTextBoxTituloAltaPub.Text = this.cPublicacion.TITULO_PUBLICACION;
            this.metroTextBoxFinicioAltaPub.Text = this.cPublicacion.FECHA_INICIO.ToString();
            this.metroTextBoxFfinAltaPub.Text = this.cPublicacion.FECHA_FIN.ToString();
            this.mcbTipoHospAltaPub.SelectedValue = this.cPublicacion.TIPO_HOSPEDAJE;
            this.metroTextBoxCapacidadAltaPub.Text = this.cPublicacion.CANT_PERSONAS.ToString();
            this.metroTextBoxDescripcionAltaPub.Text = this.cPublicacion.DESCRIPCION_PUBLICACION;
            this.mtbCalleAltaPub.Text = this.cDireccion.CALLE;
            this.mtbDeptoAltaPub.Text = this.cDireccion.DEPARTAMENTO;
            this.mtbPisoAltaPub.Text = this.cDireccion.PISO;
            this.mtbCiudadAltaPub.Text = this.cDireccion.CUIDAD;
            this.mcbPaisAltaPub.SelectedValue = this.cDireccion.PAIS;
            this.mcbProvAltaPub.SelectedValue = this.cDireccion.PROVINCIA;
            this.tableLayoutPanel4.Enabled = false;
        }

        #endregion

        private void mtbCancelarAlta_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        #region Validaciones

        private bool ValidarCampos()
        {
            if ((this.metroTextBoxTituloAltaPub.Text == "") || (this.metroTextBoxFinicioAltaPub.Text == "") || (this.metroTextBoxFfinAltaPub.Text == "") || 
            (this.metroTextBoxCapacidadAltaPub.Text == "") || (this.metroTextBoxDescripcionAltaPub.Text == "") || (this.mcbTipoHospAltaPub.SelectedValue.ToString() != "00") || 
            (this.mtbCalleAltaPub.Text == "") || (this.mtbAlutaAltaPub.Text == "") || (this.mtbCiudadAltaPub.Text == "") || (this.mcbPaisAltaPub.SelectedValue.ToString() != "8") || 
            (this.mcbProvAltaPub.SelectedValue.ToString() != "52"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void metroTextBoxFinicioAltaPub_TextChanged(object sender, EventArgs e)
        {
            if (this.metroTextBoxFinicioAltaPub.Text.Length == 2)
            {
                this.metroTextBoxFinicioAltaPub.Text += "/";
                this.metroTextBoxFinicioAltaPub.Select(this.metroTextBoxFinicioAltaPub.Text.Length, 0);
            }
            else
            {
                if (this.metroTextBoxFinicioAltaPub.Text.Length == 5)
                {
                    this.metroTextBoxFinicioAltaPub.Text += "/";
                    this.metroTextBoxFinicioAltaPub.Select(this.metroTextBoxFinicioAltaPub.Text.Length, 0);
                }
            }
        }

        private void metroTextBoxFfinAltaPub_TextChanged(object sender, EventArgs e)
        {
            if (this.metroTextBoxFfinAltaPub.Text.Length == 2)
            {
                this.metroTextBoxFfinAltaPub.Text += "/";
                this.metroTextBoxFfinAltaPub.Select(this.metroTextBoxFfinAltaPub.Text.Length, 0);
            }
            else
            {
                if (this.metroTextBoxFfinAltaPub.Text.Length == 5)
                {
                    this.metroTextBoxFfinAltaPub.Text += "/";
                    this.metroTextBoxFfinAltaPub.Select(this.metroTextBoxFfinAltaPub.Text.Length, 0);
                }
            }
        }

        #endregion

        private void mtbAceptarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.EsModificacion)
                {
                    if (ValidarCampos())
                    {
                        string[] parte = metroTextBoxFinicioAltaPub.Text.Split(new char[] { '/' });
                        DateTime fechaini = new DateTime(Convert.ToInt32(parte[2]), Convert.ToInt32(parte[1]), Convert.ToInt32(parte[0]));
                        string[] parte2 = metroTextBoxFfinAltaPub.Text.Split(new char[] { '/' });
                        DateTime fechafin = new DateTime(Convert.ToInt32(parte2[2]), Convert.ToInt32(parte2[1]), Convert.ToInt32(parte2[0]));
                        if (this.mcbUsarDireccion.Checked)
                        {
                            this.bindingSourceActualizarDir.DataSource = this.varModelo.UPD_DIRECCION(cDireccion.ID_DIRECCION, cDireccion.PAIS, cDireccion.PROVINCIA, cDireccion.CUIDAD, this.mtbCalleAltaPub.Text, this.mtbAlutaAltaPub.Text, this.mtbPisoAltaPub.Text, this.mtbDeptoAltaPub.Text);
                            this.bindingSourceAltadePublicacion.DataSource = this.varModelo.INS_PUBLICACION(ElUsuarioLogeado.UsuarioLogeado.ID_USUARIO, cDireccion.ID_DIRECCION, fechaini, fechafin, Convert.ToInt32(this.mcbTipoHospAltaPub.SelectedValue.ToString()), Convert.ToInt32(this.metroTextBoxCapacidadAltaPub.Text), ConvertAarrayBit(pbImagenPub.Image), this.metroTextBoxTituloAltaPub.Text, this.metroTextBoxDescripcionAltaPub.Text);
                            MessageBox.Show("Se ha creado una nueva publicacion de hospedaje.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.bindingSourceInsertarDir.DataSource = this.varModelo.INS_DIRECCION(this.mcbPaisAltaPub.SelectedValue.ToString(), this.mcbProvAltaPub.SelectedValue.ToString(), this.mtbCiudadAltaPub.Text, this.mtbAlutaAltaPub.Text, this.mtbCalleAltaPub.Text, this.mtbPisoAltaPub.Text, this.mtbDeptoAltaPub.Text);
                            this.bindingSourceUltimoIdDir.DataSource = this.varModelo.SEL_ULTIMO_IDDIRECION();
                            this.bindingSourceAltadePublicacion.DataSource = this.varModelo.INS_PUBLICACION(ElUsuarioLogeado.UsuarioLogeado.ID_USUARIO, Convert.ToInt32(mtUltimoIdDire.Text), fechaini, fechafin, Convert.ToInt32(this.mcbTipoHospAltaPub.SelectedValue.ToString()), Convert.ToInt32(this.metroTextBoxCapacidadAltaPub.Text), ConvertAarrayBit(pbImagenPub.Image), this.metroTextBoxTituloAltaPub.Text, this.metroTextBoxDescripcionAltaPub.Text);
                            MessageBox.Show("Se ha creado una nueva publicacion de hospedaje.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (AltadePublicacionRealizada != null)
                    {
                        AltadePublicacionRealizada();
                    }
                }
                else
                {
                    MessageBox.Show("Hay campos incompletos en el alta de publicacion.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Se a producido un error durante la operacion de alta de publicacion, vuelva a internarlo mas tarde.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte[] ConvertAarrayBit(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            catch { return ms.ToArray(); }
        }

        string st = "";

        private void mbCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                st = op.FileName;
                this.pbImagenPub.Image = Image.FromFile(st);
            }
        }

        private void mcbUsarDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.mcbUsarDireccion.Checked)
            {
                this.mcbProvAltaPub.SelectedValue = this.cDireccion.PROVINCIA;
                this.mcbPaisAltaPub.SelectedValue = this.cDireccion.PAIS;
                this.mtbCiudadAltaPub.Text = this.cDireccion.CUIDAD;
            }
            else
            {
                this.mcbProvAltaPub.SelectedValue = "52";
                this.mcbPaisAltaPub.SelectedValue = "8";
                this.mtbCiudadAltaPub.Text = "";
            }
        }

       
    }
}