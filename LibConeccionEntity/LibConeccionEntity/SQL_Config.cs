using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;

namespace LibConeccionEntity
{
    public class SQL_Config : DbConfiguration
    {
        public SQL_Config()
        {
            SetProviderServices(SqlProviderServices.ProviderInvariantName,SqlProviderServices.Instance);
            SetDefaultConnectionFactory(new SqlConnectionFactory());
        }
    }
}
