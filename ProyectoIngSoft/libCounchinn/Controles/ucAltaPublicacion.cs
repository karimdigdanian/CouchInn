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

        public int id;

        private string st = "";

        #endregion

        #region Propiedades


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
<<<<<<< HEAD
=======
                this.metroTextBoxFinicioAltaPub.Text = DateTime.Now.Date.ToShortDateString();
                this.metroTextBoxFfinAltaPub.Text = DateTime.Now.Date.AddDays(7).ToShortDateString();
                this.pbImagenPub.Image = this.varModelo.SelectImagenNoDisponible();
                this.mbCargarImagen.Text = "Cargar imagen";
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
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
            this.metroTextBoxFinicioAltaPub.Text = Convert.ToDateTime(this.cPublicacion.FECHA_INICIO.ToString()).ToShortDateString();
            this.metroTextBoxFfinAltaPub.Text = Convert.ToDateTime(this.cPublicacion.FECHA_FIN.ToString()).ToShortDateString();
            this.mcbTipoHospAltaPub.SelectedValue = this.cPublicacion.TIPO_HOSPEDAJE;
            this.metroTextBoxCapacidadAltaPub.Text = this.cPublicacion.CANT_PERSONAS.ToString();
            this.metroTextBoxDescripcionAltaPub.Text = this.cPublicacion.DESCRIPCION_PUBLICACION;
            this.mtbCalleAltaPub.Text = this.cDireccion.CALLE;
            this.mtbDeptoAltaPub.Text = this.cDireccion.DEPARTAMENTO;
            this.mtbPisoAltaPub.Text = this.cDireccion.PISO;
            this.mtbCiudadAltaPub.Text = this.cDireccion.CUIDAD;
            this.mcbPaisAltaPub.SelectedValue = this.cDireccion.PAIS;
            this.mcbProvAltaPub.SelectedValue = this.cDireccion.PROVINCIA;
            if (this.cPublicacion.FOTO_PRINCIPAL != null)
            {
                this.pbImagenPub.Image = ConvertArrayImage(this.cPublicacion.FOTO_PRINCIPAL.ToArray());
            }
            else
            {

            }
            this.bindingSourceSelImagenesPublicacion.DataSource = this.varModelo.SEL_IMAGENES_PUBLICACION(Convert.ToInt32(this.cPublicacion.ID_PUBLICACION));
            if (varModelo.ExisteReservaEnPublicacion(this.cPublicacion.ID_PUBLICACION))
            {
<<<<<<< HEAD
                this.metroTextBoxFinicioAltaPub.Enabled = false;
                this.metroTextBoxFfinAltaPub.Enabled = false;
                MessageBox.Show("La publicacion contine reservas, debido a esto no se podran modificar las fechas de la publicacion");
            }
            else
            {
                this.metroTextBoxFinicioAltaPub.Enabled = true;
                this.metroTextBoxFfinAltaPub.Enabled = true;
=======
                this.EstadoPantalla(false);
                MessageBox.Show("Hay reservas en la publicacion, no se puede modificar los campos debido a esto","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                this.EstadoPantalla(true);
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
            }
        }

        #endregion

        #region Validaciones

        private bool ValidarCampos()
        {
            if ((this.metroTextBoxTituloAltaPub.Text == "") || (this.metroTextBoxFinicioAltaPub.Text == "") || (this.metroTextBoxFfinAltaPub.Text == "") || 
<<<<<<< HEAD
            (this.metroTextBoxCapacidadAltaPub.Text == "") || (this.metroTextBoxDescripcionAltaPub.Text == "") || (this.mcbTipoHospAltaPub.SelectedValue.ToString() != "00") || 
            (this.mtbCalleAltaPub.Text == "") || (this.mtbAlutaAltaPub.Text == "") || (this.mtbCiudadAltaPub.Text == "") || (this.mcbPaisAltaPub.SelectedValue.ToString() != "8") || 
            (this.mcbProvAltaPub.SelectedValue.ToString() != "52"))
            {
                return true;
            }
            else
            {
                return false;
=======
            (this.metroTextBoxCapacidadAltaPub.Text == "") || (this.metroTextBoxDescripcionAltaPub.Text == "") || (this.mcbTipoHospAltaPub.SelectedValue.ToString() == "00") || 
            (this.mtbCalleAltaPub.Text == "") || (this.mtbAlutaAltaPub.Text == "") || (this.mtbCiudadAltaPub.Text == "") || (this.mcbPaisAltaPub.SelectedValue.ToString() == "8") || 
            (this.mcbProvAltaPub.SelectedValue.ToString() == "52"))
            {
                return false;
            }
            else
            {
                return true;
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
            }
        }

        private void metroTextBoxFinicioAltaPub_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            //
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
        }

        private void metroTextBoxFfinAltaPub_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
         //
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
        }

        #endregion

        #region Eventos y metodos privados

        private void mtbAceptarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.EsModificacion)
                {
                    if (ValidarCampos())
                    {
                        string[] parte = metroTextBoxFinicioAltaPub.Text.Split(new char[] { '/' });
                        DateTime fechaini = new DateTime(Convert.ToInt32(parte[2]), Convert.ToInt32(parte[1]), Convert.ToInt32(parte[0]));
                        string[] parte2 = metroTextBoxFfinAltaPub.Text.Split(new char[] { '/' });
                        DateTime fechafin = new DateTime(Convert.ToInt32(parte2[2]), Convert.ToInt32(parte2[1]), Convert.ToInt32(parte2[0]));
<<<<<<< HEAD
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
=======
                        if ((fechaini <= DateTime.Now.Date) && (fechafin > fechaini))
                        {
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
                        else
                        {
                            MessageBox.Show("Hay incoherencia en los campos de fechas, verifiquelos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos incompletos en el alta de publicacion.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string[] parte = metroTextBoxFinicioAltaPub.Text.Split(new char[] { '/' });
                    DateTime fechaini = new DateTime(Convert.ToInt32(parte[2]), Convert.ToInt32(parte[1]), Convert.ToInt32(parte[0]));
                    string[] parte2 = metroTextBoxFfinAltaPub.Text.Split(new char[] { '/' });
                    DateTime fechafin = new DateTime(Convert.ToInt32(parte2[2]), Convert.ToInt32(parte2[1]), Convert.ToInt32(parte2[0]));
                    this.bindingSourceAtualizaPublicacion.DataSource = this.varModelo.UPD_PUBLICACION(this.cPublicacion.ID_PUBLICACION, this.metroTextBoxTituloAltaPub.Text, fechaini, fechafin, this.metroTextBoxDescripcionAltaPub.Text, Convert.ToInt32(this.metroTextBoxCapacidadAltaPub.Text), Convert.ToInt32(this.mcbTipoHospAltaPub.SelectedValue), true, this.ConvertAarrayBit(this.pbImagenPub.Image));
                    this.bindingSourceActualizarDir.DataSource = this.varModelo.UPD_DIRECCION(cDireccion.ID_DIRECCION, cDireccion.PAIS, cDireccion.PROVINCIA, cDireccion.CUIDAD, this.mtbCalleAltaPub.Text, this.mtbAlutaAltaPub.Text, this.mtbPisoAltaPub.Text, this.mtbDeptoAltaPub.Text);
                    MessageBox.Show("La publicacion se ha modificado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (AltadePublicacionRealizada != null)
                {
                    AltadePublicacionRealizada();
                }
            }
            catch
            {
                MessageBox.Show("Se a producido un error durante la operacion de alta de publicacion, vuelva a internarlo mas tarde.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtbCancelarAlta_Click(object sender, EventArgs e)
        {
            this.SendToBack();
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

        public Image ConvertArrayImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void mbCargarImagen_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                st = op.FileName;
                this.pbImagenPub.Image = Image.FromFile(st);
            }
=======
            if (this.mbCargarImagen.Text == "Cargar imagen")
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    st = op.FileName;
                    this.pbImagenPub.Image = Image.FromFile(st);
                    this.mbCargarImagen.Text = "Cargar mas imagenes";
                }
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    //st = op.FileName;
                    //this.pbImagenPub.Image = Image.FromFile(st);
                    //this.bindingSourceInsrtImagen.DataSource = varModelo.INS_IMAGEN_PUBLICACION(this.ConverAarrayBit(pictureBox2.Image), );
                    //this.bindingSourceInsrtImagen.EndEdit();
                }
            }

>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
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

        private void button1_Click(object sender, EventArgs e)
        {
            InicializarModificacion(id);
        }

<<<<<<< HEAD
        #endregion
=======
        private void EstadoPantalla(bool estado)
        {
            this.tableLayoutPanel1.Enabled = estado;
        }

        #endregion

        private void metroTextBoxFinicioAltaPub_Leave(object sender, EventArgs e)
        {
            if (EsModificacion)
            {
                if (Convert.ToDateTime(this.metroTextBoxFinicioAltaPub.Text) < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha ingresada es menor a la actual","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    this.metroTextBoxFinicioAltaPub.Focus();
                }
            }

        }

        private void metroTextBoxFfinAltaPub_Leave(object sender, EventArgs e)
        {
            if (EsModificacion)
            {
                if (!((Convert.ToDateTime(this.metroTextBoxFfinAltaPub.Text) > DateTime.Now.Date) && (Convert.ToDateTime(this.metroTextBoxFfinAltaPub.Text) > Convert.ToDateTime(this.metroTextBoxFinicioAltaPub.Text))))
                {
                    MessageBox.Show("La fecha de fin ingresada es menor a la actual o menor a la fecha ingresada como inicio de publicacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.metroTextBoxFfinAltaPub.Focus();
                }
            }

        }

        private void metroTextBoxFinicioAltaPub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(ConsoleKey.Backspace))
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
        }

        private void metroTextBoxFfinAltaPub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(ConsoleKey.Backspace))
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
        }
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
    }
}