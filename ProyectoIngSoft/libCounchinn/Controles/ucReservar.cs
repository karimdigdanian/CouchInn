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
    public partial class ucReservar : UserControl
    {
        #region variables

        private ModeloLibCouchin varModelo;

        private PUBLICACION cPublicacion;

        private int idPublicacion;


        #endregion

        public ucReservar()
        {
            InitializeComponent();
        }

        public void Inicializar(int id)
        {
            idPublicacion = id;
            this.varModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
            this.bindingSelReservas.DataSource = this.varModelo.SEL_RESERVAS(id);
            //this.mGridReservas.DataSource = this.bindingSelReservas;
            this.cPublicacion = varModelo.SelectPublicacionXId(id);
        }

        private Boolean rangoCorrecto(DateTime i, DateTime f) // Devuelvo true si el rango enviado como parametro se 
                                                              // encuentre dentro del de publicacion y es mayor o igual a la fecha de hoy
        {
            if((i >= cPublicacion.FECHA_INICIO)&&(i <= cPublicacion.FECHA_FIN)&& 
                (f >= cPublicacion.FECHA_INICIO) && (f <= cPublicacion.FECHA_FIN)&&
                (i < f)&&(i > (DateTime.Today)))
            {
                return true;
            }
            return false;
        }

        private void mBtnReservar_Click(object sender, EventArgs e)
        {
            DateTime inicioBox;
            DateTime finBox;
            if ((this.mTBDesde.Text != "") && (this.mTBHasta.Text != "")) //Verifico que no esten vacios los campos
            {
                try //verifico que las fechas ingresadas sean de tipo fecha
                {
                    inicioBox = Convert.ToDateTime(this.mTBDesde.Text);
                    finBox = Convert.ToDateTime(this.mTBHasta.Text);
                }
                catch
                {
                    MessageBox.Show("Fecha de inicio/fin ingresada no valida/s.", "Problema con fechas ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Campo/s de fecha inicio/fin vacio/s.", "Ingrese informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Si los campos tienen fechas validas evaluo el rango y comparo con todas las reservas, si es que existen cargadas
            if (this.rangoCorrecto(inicioBox, finBox))
            { 
                if (this.mGridReservas.RowCount != 0)
                {
                    for (int i = 0; i < this.mGridReservas.RowCount; i++)
                    {
                        DateTime inicioGrid = Convert.ToDateTime(this.mGridReservas[0, i].Value);
                        DateTime finGrid = Convert.ToDateTime(this.mGridReservas[1, i].Value);
                        if ((inicioBox != inicioGrid) && (inicioBox != finGrid) //comparo que ningun inicio/fin sea igual a otro
                            && (finBox != inicioGrid) && (finBox != finGrid)) 
                        {
                            if ((inicioBox < inicioGrid) && (finBox > finGrid))  //verifico que el rango ingresado no contenga una reserva DENTRO.
                            {
                                MessageBox.Show("La reserva contiene una reserva existene.", "Problema al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                if ((inicioBox > inicioGrid) && (inicioBox < finGrid)) //verifico que el inicio no caiga dentro de una reserva
                                {
                                    MessageBox.Show("El inicio de la reserva se superpone con una existene.", "Problema al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if((finBox < finGrid) && (finBox > inicioGrid)) //verifico que el fin no caiga dentro de una reserva
                                    {
                                        MessageBox.Show("El fin de la reserva se superpone con una existene.", "Problema al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    else
                                    {
                                        //Pass
                                        
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("La reserva se superpone con una existene. (Una reserva no puede comenzar/finalizar el dia de comienzo/fin de otra).", "Problema al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Las fechas ingresadas no se encuentran dentro del tiempo ofrecido.", "Fechas fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.bindingInsReserva.DataSource = this.varModelo.INS_RESERVA(ElUsuarioLogeado.Retorna_Id_Usuario,cPublicacion.ID_USUARIO,cPublicacion.ID_PUBLICACION,Convert.ToDateTime(DateTime.Now.ToShortDateString()),inicioBox,finBox);
            MessageBox.Show("Reserva realizada con exito.", "¡Reserva satisfactoria!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.bindingSelReservas.DataSource = this.varModelo.SEL_RESERVAS(idPublicacion);
            this.mGridReservas.DataSource = this.bindingSelReservas;
        }
    }
}
