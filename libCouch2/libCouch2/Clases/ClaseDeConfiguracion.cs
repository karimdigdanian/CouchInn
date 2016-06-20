using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

namespace libCouch2.Clases
{
    public class ClaseDeConfiguracion
    {
        #region Propiedades y Metodos de cadena de conexion

        private static string _strConexion = "";
        public static string SQLConnectionString
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    ClaseDeConfiguracion._strConexion = value;
                    ClaseDeConfiguracion._EFConnectionString = ClaseDeConfiguracion.getEFConnectionString(value);
                }
            }
        }

        private static string _EFConnectionString = "";
        public static string EFConnectionString
        {
            get
            {
                return ClaseDeConfiguracion._EFConnectionString;
            }
        }

        private static string getEFConnectionString(string strConexionSQL)
        {
            SqlConnectionStringBuilder sqlConnStr = new SqlConnectionStringBuilder(strConexionSQL);

            sqlConnStr.MultipleActiveResultSets = true;

            EntityConnectionStringBuilder efConnString = new EntityConnectionStringBuilder();

            efConnString.Provider = "System.Data.SqlClient";
            efConnString.ProviderConnectionString = sqlConnStr.ToString();
            efConnString.Metadata = (@"res://*/Modelo.ModeloLibCouchin.csdl|" +
                                     @"res://*/Modelo.ModeloLibCouchin.ssdl|" +
                                     @"res://*/Modelo.ModeloLibCouchin.msl");

            return efConnString.ToString();
        }

        #endregion
    }
}
