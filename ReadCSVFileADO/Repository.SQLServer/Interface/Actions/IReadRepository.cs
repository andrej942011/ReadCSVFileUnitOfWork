using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.RepositorySQLServer.Interface.Actions
{
    public interface IReadRepository<T, Y, X> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Y id);
        T GetName(X name);
        DataTable ExecuteReaderTable(string query, SqlParameter[] sqlParameters);
        List<T> ExecuteReader(string query, SqlParameter[] sqlParameters);
    }
}
