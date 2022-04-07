using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.Services.Interface
{
    public interface IService<T, TypeRepo> where T:class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T GetName(string name);
        DataTable ExecuteReaderTable(string query, SqlParameter[] sqlParameters);
        void Create(T model);
        void Update(T model);
        void Delete(T model);
    }
}
