using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConeccionEntity;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure;
using libCouch2.Modelo;


namespace libCouch2.Modelo
{
    [DbConfigurationType(typeof(SQL_Config))]

    public class ModeloLibCouchin : DbContext
    {

    }

}
