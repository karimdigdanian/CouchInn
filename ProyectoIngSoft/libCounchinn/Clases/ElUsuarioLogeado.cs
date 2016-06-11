using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libCounchinn.Modelo;
using libCounchinn.Clases;

namespace libCounchinn.Clases
{
    public class ElUsuarioLogeado
    {
        private static USUARIO _UsuarioLogeado;
        public static USUARIO UsuarioLogeado
        {
            get
            {
                return _UsuarioLogeado;
            }
            set
            {
                _UsuarioLogeado = value;
            }
        }
        public static int Retorna_Tipo_Usuario
        {
            get
            {
                if (_UsuarioLogeado != null)
                {
                    return (int)_UsuarioLogeado.TIPO_USUARIO;
                }
                else
                {
                    return 00;
                }
            }
        }
        public static int Retorna_Id_Usuario
        {
            get
            {
                if (_UsuarioLogeado != null)
                {
                    return (int)_UsuarioLogeado.ID_USUARIO;
                }
                else
                {
                    return 00;
                }
            }
        }
        public static string Retorna_Nombre_Usuario
        {
            get{
                if (_UsuarioLogeado != null)
                {
                    return (string)_UsuarioLogeado.NOMRE_USUARIO;
                }
                else
                {
                    return null;
                }
            }
        }
        public static int Retorna_Id_Persona
        {
            get{
                if (_UsuarioLogeado != null)
                {
                    return (int)_UsuarioLogeado.ID_PERSONA;
                }
                else
                {
                    return 00;
                }
            }
        }
    }
}
