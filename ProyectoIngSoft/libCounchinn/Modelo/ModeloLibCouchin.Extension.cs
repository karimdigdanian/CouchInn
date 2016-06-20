using System;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using LibConeccionEntity;
using libCounchinn.Clases;
using libCounchinn.Modelo;

namespace libCounchinn.Modelo
{
    [DbConfigurationType(typeof(SQL_Config))]

    public partial class ModeloLibCouchin : DbContext
    {
        public ModeloLibCouchin(string strEFCnxString) : base (strEFCnxString)
        {

        }

        #region Metodos sobre persona

        public PERSONA SelectPersonaXid(int idPersona)
        {
            var consulta = (from PERSONA p in this.PERSONAs
                            where p.ID_PERSONA == idPersona
                            select p).FirstOrDefault();
            return consulta;
        }

        #endregion

        #region Metodos sobre Usuiario

        public USUARIO SelectUsuario(string stUsuario,string stPass)
        {
            var consulta = (
                from USUARIO tu in this.USUARIOs
                where tu.NOMRE_USUARIO == stUsuario && tu.CONTRASEÑA == stPass
                select tu
                ).FirstOrDefault();
            return consulta;
        }

        public string SelectEmailUsuario(string stUsuario)
        {
            var consulta = (
                from USUARIO tu in this.USUARIOs
                where tu.NOMRE_USUARIO == stUsuario
                select tu
                ).FirstOrDefault();
            if (consulta != null && consulta.ESTADO_USUARIO == true)
            {
                var consultaEmail = (
                    from PERSONA per in this.PERSONAs
                    where per.ID_PERSONA == consulta.ID_PERSONA
                    select per.E_MAIL_LARGO
                    ).FirstOrDefault();
                return consultaEmail;
            }
            else
            {
                if (consulta != null)
                {
                    return "Usuario bloqueado";
                }
                else
                {
                    return null;
                }
            }
        }

        public int SelectIdUsuarioxNombreUsuario(string NombreUsuario)
        {
            var consulta = (
                from USUARIO u in this.USUARIOs
                where u.NOMRE_USUARIO == NombreUsuario
                select u.ID_USUARIO
                ).FirstOrDefault();
            return consulta;
            
        }
        public USUARIO SelectUsuarioxNombreUsuario(string NombreUsuario)
        {
            var consulta = (
                from USUARIO u in this.USUARIOs
                where u.NOMRE_USUARIO == NombreUsuario
                select u
                ).FirstOrDefault();
            return consulta;

        }

        public bool ExisteUsuario(string stNombre)
        {
            var consulta = (
                from USUARIO u in this.USUARIOs
                where u.NOMRE_USUARIO == stNombre
                select u
                ).FirstOrDefault();
            if (consulta != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public USUARIO SelectUsuarioXid(int idUsuario)
        {
            var consulta = (from USUARIO u in this.USUARIOs
                            where u.ID_USUARIO == idUsuario
                            select u).FirstOrDefault();
            return consulta;
        }
        #endregion

        #region Metodos sobre Tipo_Hospedaje


        public String EstadoTipoHospedaje(string stTipoHospeNuevo)
        {
            var consulta2 = (
                from TIPO_HOSPEDAJE th in this.TIPO_HOSPEDAJE
                where   th.DESCRIPCION == stTipoHospeNuevo
                select th
                ).FirstOrDefault();
            if (consulta2 != null)
            {
                if (consulta2.ESTADO == false)
                {
                    return "Baja";
                }
                else
                {
                    return "Activo";
                }
            }
            else
            {
                return "NoExiste";
            }
        }
        public TIPO_HOSPEDAJE SelectTipoHospedajeXtipoHospeDescripion(string stTipoHospeNuevo)
        {
            var consulta2 = (
            from TIPO_HOSPEDAJE th in this.TIPO_HOSPEDAJE
            where th.DESCRIPCION == stTipoHospeNuevo 
            select th
            ).FirstOrDefault();
            return consulta2;
        }

        #endregion

        #region Metodos sombre direcciones

        public DIRECCION SelectDireccionXID(int idDir)
        {
            var consulta = (
                from DIRECCION d in this.DIRECCIONs
                where d.ID_DIRECCION == idDir
                select d
                ).FirstOrDefault();
            return consulta;
        }

        #endregion

        #region Metodos combos

        public void CargarMetroComboTablas(ref MetroFramework.Controls.MetroComboBox mcb,string CodTablas)
        {
            mcb.DataSource = this.CargarMetroCombo(CodTablas);
            mcb.DisplayMember = "DESCRIPCION";
            mcb.ValueMember = "CLAVE";
        }


        public IList<TABLAS> CargarMetroCombo(string stClave)
        {
            var consulta = (
                from TABLAS t in this.TABLASDescripciones
                where t.COD_TABLA == stClave
                select t
                ).ToList();
            return consulta;
        }


        public void CargarMetroComboTiposHospedaje(ref MetroFramework.Controls.MetroComboBox mcb)
        {
            mcb.DataSource = this.CargarMetroComboTipoHospedaje();
            mcb.DisplayMember = "DESCRIPCION";
            mcb.ValueMember = "ID_TIPO_HOSPEDAJE";
        }


        public IList<TIPO_HOSPEDAJE> CargarMetroComboTipoHospedaje()
        {
            var consulta = (
                from TIPO_HOSPEDAJE t in this.TIPO_HOSPEDAJE
                where t.ESTADO != false
                select t
                ).ToList();
            return consulta;
        }

        #endregion

        #region Metodos sobre publicaciones

        public PUBLICACION SelectPublicacionXId (int idPub)
        {
            var consulta = (
                from PUBLICACION p in this.PUBLICACIONs
                where p.ID_PUBLICACION == idPub
                select p
                ).FirstOrDefault();
            return consulta;
        }



        #endregion

        #region Motodos sobre reservas

        public Boolean ExisteReservaEnPublicacion(int idPub)
        {
            var consulta = (
                from RESERVA r in this.RESERVAS
                where r.ID_PUBLICACION == idPub
                select r
                ).FirstOrDefault();
            if (consulta != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
<<<<<<< HEAD
=======

        #region Metodos sombre tabla fotos

        public Image SelectImagenNoDisponible()
        {
            var consulta = (
                from FOTO f in this.FOTOS
                where f.ID_PUBLICACION == 0
                select f.IMAGEN
                ).FirstOrDefault();
            MemoryStream ms = new MemoryStream(consulta);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        #endregion
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
    }
}
