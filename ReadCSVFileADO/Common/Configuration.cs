using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.Common
{
    public class Configuration
    {
        public string ServerName { get; set; }
        public string ConnectionString { get; set; }
        public bool СurrentСar { get; set; }
        public string EndSt { get; set; }

        public string GetConnectionString()
        {
            string outConnection  = "";
            if (СurrentСar)
                outConnection = String.Format(ConnectionString, Environment.MachineName);
            else
                outConnection = String.Format(ServerName, Environment.MachineName);

            return outConnection;
        }

        public string GetHostName()
        {
            return Environment.MachineName;
        }

    }
}
