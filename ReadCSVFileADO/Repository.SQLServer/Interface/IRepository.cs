using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.RepositorySQLServer.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get1(int id);
        List<TEntity> ExecuteReader(string query, SqlParameter[] sqlParameters);
        DataTable ExecuteReaderTable(string query, SqlParameter[] sqlParameters);
    }
}
