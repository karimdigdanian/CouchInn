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
using System.IO;

namespace libCounchinn.Controles
{
    public partial class ucCuerpo : UserControl
    {
        #region PopiedadeModoPantalla

        private Modo_Pantalla _Modo;
        public Modo_Pantalla Modo
        {
            get
            {
                return _Modo;
            }
            set
            {
                this._Modo = value;
            }
        }

        #endregion

        #region Delegados/Eventos
        private ModeloLibCouchin VarModelo;

        public event DelegadoLogin SesionCerrada;

        public event DelegadoLogin IniciarSesion;
        #endregion

        public ucCuerpo()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            if (ElUsuarioLogeado.UsuarioLogeado != null)
            {
                this.tableLayoutPanelConInicioSesion.Visible = false;
                this.ucAltaTipoHospedaje1.SendToBack();
                this.ucTopLogueado1.Inicializar();
                this.ucPestanias1.Inicializar();
                if (ElUsuarioLogeado.UsuarioLogeado.TIPO_USUARIO == 3)
                {
                    this.metroLinkContribucion.Visible = true;
                }
                else
                {
                    this.metroLinkContribucion.Visible = false;
                }
            }
            else
            {
                this.metroLinkContribucion.Visible = false;
                this.tableLayoutPanelConInicioSesion.Visible = true;
                this.ucAltaTipoHospedaje1.SendToBack();
                this.ucTopLogueado1.Inicializar();
                this.ucPestanias1.Inicializar();
            }
        }

        private void mbtIniciarSesion_Click(object sender, EventArgs e)
        {
            this.ucLogin21.Inicializar();
        }

        private void metroLinkContribucion_Click(object sender, EventArgs e)
        {
            this.usContribucion1.Inicializar();
            this.usContribucion1.Visible = true;
            this.usContribucion1.BringToFront();
        }

        private void ucLogin21_EventoLoginSactifactorio()
        {
            ElUsuarioLogeado.UsuarioLogeado = this.ucLogin21.UsuarioActual;
            this.ucLogin21.SendToBack();
            this.Inicializar();
        }

        private void ucTopLogueado1_CerrarSesion_1()
        {
            ElUsuarioLogeado.UsuarioLogeado = null;
            this.Inicializar();
        }

        private void ucTopLogueado1_Administrar()
        {
            this.ucAltaTipoHospedaje1.inicializar();
            this.ucAltaTipoHospedaje1.BringToFront();
            this.ucPestanias1.SendToBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ucPestanias1.Inicializar();
            this.ucPestanias1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.VarModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
                this.bindingSource2.DataSource = VarModelo.INS_IMAGEN_PUBLICACION(this.ConverAarrayBit(pictureBox2.Image),2);
                this.bindingSource2.EndEdit();
                MessageBox.Show("Mensaje de confirmacion", "Tipo de operacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            catch
            {
                MessageBox.Show(this, "Error al guardar datos, la operacion no fue sactifactoria", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public byte[] ConverAarrayBit(System.Drawing.Image imageIn)
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
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                st = op.FileName;
                pictureBox2.Image = Image.FromFile(st);
            }
        }

        private void mbtRegistrarse_Click(object sender, EventArgs e)
        {
            this.ucAltadeUsuario1.InicializarAlta();
            this.ucAltadeUsuario1.BringToFront();
        }

        private void usContribucion1_ContribucionRealizada()
        {
            ElUsuarioLogeado.UsuarioLogeado.TIPO_USUARIO = 2;
            this.Inicializar();
        }

        private void ucTopLogueado1_VerCuenta()
        {
            this.ucAltadeUsuario1.InicializarModificacion();
            this.ucAltadeUsuario1.BringToFront();



        }
    }
}
