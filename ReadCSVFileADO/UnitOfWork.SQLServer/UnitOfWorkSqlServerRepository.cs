using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer;
using ReadCSVFileADO.RepositorySQLServer.Interface;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.UnitOfWorkSQLServer
{
    public class UnitOfWorkSqlServerRepository:IUnitOfWorkRepository
    {
        public Dictionary<Type, object> Repositories { get; set; }
        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            Repositories = new Dictionary<Type, object>();

            Repositories.Add(typeof(Category), new CategoryRepository(context, transaction));
            Repositories.Add(typeof(City), new CityRepository(context, transaction));
            Repositories.Add(typeof(Gender), new GenderRepository(context, transaction));
            Repositories.Add(typeof(Information), new InformationRepository(context, transaction));
            Repositories.Add(typeof(User), new UserRepository(context, transaction));
        }

        public object GetRepository<TEntity>()
            where TEntity : class
        {
            if (Repositories is null)
                Repositories = new Dictionary<Type, object>();

            Type entityType = typeof(TEntity);

            if (Repositories.ContainsKey(entityType))
                return Repositories[entityType];

            //поиск типа репозитория, для указанного объекта
            var repositoryType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .First(type =>
                            type.BaseType != null &&
                            type.BaseType.Equals(typeof(Repository<TEntity>)));

            var repositoryInstance = Activator.CreateInstance(repositoryType, Repositories.Values) ??
                                     throw new Exception($"Cannot create instance of {repositoryType.Name}");

            Repositories[entityType] = repositoryInstance;
            return repositoryInstance;
        }
    }
}
