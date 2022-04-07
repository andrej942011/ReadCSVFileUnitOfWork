using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer.Interface.Actions;

namespace ReadCSVFileADO.RepositorySQLServer.Interface
{
    public interface IUserRepository: IReadRepository<User, int, string>, ICreateRepository<User>,
        IUpdateRepository<User>, IRemoveRepository<User>
    {
        
    }
}
