using ReadCSVFileADO.RepositorySQLServer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.UnitOfWorkSQLServer.Interface
{
    public interface IUnitOfWorkRepository
    {
        Dictionary<Type, object> Repositories { get; set; }
        object GetRepository<TEntity>()
            where TEntity : class;
    }
}
