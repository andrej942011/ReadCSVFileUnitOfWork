using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer.Interface.Actions;

namespace ReadCSVFileADO.RepositorySQLServer.Interface
{
    public interface ICategoryRepository:IRepository<Category>, IReadRepository<Category, int, string>,
        ICreateRepository<Category>, IUpdateRepository<Category>, IRemoveRepository<Category>
    {
        
    }
}
