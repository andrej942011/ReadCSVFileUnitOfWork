using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.UnitOfWorkSQLServer.Interface
{
    public interface IUnitOfWorkAdapter:IDisposable
    {
        SqlConnection _context { get; set; }
        SqlTransaction _transaction { get; set; }
        IUnitOfWorkRepository Repositories { get; }
        void SaveChanges();
    }
}
