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

namespace libCouch2.Controles
{
    public partial class ucAltadeUsuario : UserControl
    {
        #region variables

        private USUARIO cUsuario;

        private PERSONA cPersona;

        private int idTemporal;

        private ModeloLibCouchin varModelo;

        #endregion

        #region Inicializacion

        public ucAltadeUsuario()
        {
            InitializeComponent();
        }

        public void InicializarAlta()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            ElUsuarioLogeado.UsuarioLogeado = null;
            this.cPersona = new PERSONA();
            this.cUsuario = new USUARIO();
            this.varModelo.CargarMetroComboTablas(ref mcbPais, "03");
            this.varModelo.CargarMetroComboTablas(ref mcbProvincia, "05");
            this.mcbProvincia.SelectedValue = "47";
        }
        public void InicializarModificacion()
        {
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.varModelo.CargarMetroComboTablas(ref mcbPais, "03");
            this.varModelo.CargarMetroComboTablas(ref mcbProvincia, "05");
            this.cUsuario = this.varModelo.SelectUsuarioXid(ElUsuarioLogeado.Retorna_Id_Usuario);
            this.cPersona = this.varModelo.SelectPersonaXid(ElUsuarioLogeado.Retorna_Id_Persona);
            this.CargarCamposConUsuario();
        }

        #endregion

        #region Eventos Privados

        private void mtAceptarAlta_Click(object sender, EventArgs e)
        {
            if (this.varModelo.ExisteUsuario(this.mtxtbNombreUsu.Text))
            {
                MessageBox.Show("El nombre de usuario ya existe. Intenta con otro nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.mtxtbNombreUsu.Focus();
            }
            else
            {
                if (this.ValidarCampos())
                {
                    this.bindingSource1.DataSource = this.varModelo.INS_PERSONA(this.mtxtbNombre.Text, this.mtxtbApellido.Text, this.mtxtbEmail.Text);
                    this.bindingSourceUltimoId.DataSource = this.varModelo.SEL_ULTIMO_ID_PERSONA();
                    this.bindingSource2.DataSource = this.varModelo.INS_USUARIO(Convert.ToInt32(this.UltimoId.Text), this.mtxtbNombreUsu.Text, this.mtxtbContraseña.Text, 3);
                    MessageBox.Show("El usuario se ha creado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.SendToBack();
                    this.inicializarCampos();
                }
                else
                {
                    MessageBox.Show("Verifique los datos ingresados, hay campos incompletos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mbCancelarAlta_Click(object sender, EventArgs e)
        {
            this.inicializarCampos();
            this.SendToBack();
        }

        #endregion

        #region Metodos Privados

        private void inicializarCampos()
        {
            this.mtxtbNombre.Text = "Ejemplo: Juan";
            this.mtxtbApellido.Text = "Ejemplo: Perez";
            this.mtxtbEmail.Text = "correoelectronico@ejemplo.com";
            this.mtxtbNombreUsu.Text = "Ejemplo: Juan10";
            this.mtxtbContraseña.Text = "";
            this.mcbProvincia.SelectedValue = "47";
        }
        private void CargarCamposConUsuario()
        {
            this.mtxtbNombre.Text = this.cPersona.NOMBRE;
            this.mtxtbApellido.Text = this.cPersona.APELLIDO;
            this.mtxtbEmail.Text = this.cPersona.E_MAIL_LARGO;
            this.mtxtbNombreUsu.Text = this.cUsuario.NOMRE_USUARIO;
            this.mtxtbContraseña.Text = this.cUsuario.CONTRASEÑA;
            this.mcbProvincia.SelectedValue = "47";
        }
        private bool ValidarCampos()
        {
            if ((this.mtxtbNombre.Text == "") ||  (this.mtxtbApellido.Text == "") || (this.mtxtbEmail.Text == "") || (this.mtxtbNombreUsu.Text == "") || (this.mtxtbContraseña.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}
