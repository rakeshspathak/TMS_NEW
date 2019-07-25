using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;

namespace TMS.Persistant
{
    public class DatabaseContext : IDisposable
    {
        private readonly string _connectionString = "server=N-HCLT-EISDEV\\SQLSERVER,1497;database=TMS_Sandbox;uid=tmsystem;password=tmsystem#123;Connection Timeout=0;";//read from config
        protected static SqlDatabase sqlDatabase;

        public DatabaseContext()
        {
            sqlDatabase = new SqlDatabase(_connectionString);
        }

        public void Dispose()
        {
            if (sqlDatabase != null)
                sqlDatabase = null;
        }
    }
}
