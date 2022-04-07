using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.RepositorySQLServer.Interface.Actions
{
    public interface IRemoveRepository<T> where T : class
    {
        void Remove(T t);
    }
}
