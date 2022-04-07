using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer.Interface.Actions;

namespace ReadCSVFileADO.RepositorySQLServer.Interface
{
    public interface IGenderRepository : IReadRepository<Gender, int, string>,
        ICreateRepository<Gender>, IUpdateRepository<Gender>, IRemoveRepository<Gender>
    {
        
    }
}
