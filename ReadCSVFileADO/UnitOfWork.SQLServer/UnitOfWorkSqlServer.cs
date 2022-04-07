using ReadCSVFileADO.Common;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.UnitOfWorkSQLServer
{
    public class UnitOfWorkSqlServer:IUnitOfWork
    {
        //private IConfiguration _configuration; //NetCore

        public UnitOfWorkSqlServer()
        {

        }

        
        public IUnitOfWorkAdapter Create()
        {
            //return new UnitOfWorkSqlServerAdapter(Parameter.ConnectionStringHome);
            var xmlConfiguration = new XMLConfig("configuration");
            var connectionString = xmlConfiguration.ReadFile<Configuration>();

            return new UnitOfWorkSqlServerAdapter(connectionString.GetConnectionString());
        }
    }
}
