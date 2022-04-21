using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer;
using ReadCSVFileADO.RepositorySQLServer.Interface;
using ReadCSVFileADO.Services.Interface;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;

namespace ReadCSVFileADO.Services
{
    public class ServicesDB
    {
        public Dictionary<Type, object> Repositories { get; }

        public ServicesDB(IUnitOfWork unitOfWork)
        {
            Repositories = new Dictionary<Type, object>();

            Repositories.Add(typeof(IService<Category, CategoryRepository>), new ServiceDB<Category, CategoryRepository>(unitOfWork));
            Repositories.Add(typeof(IService<City, CityRepository>), new ServiceDB<City, CityRepository>(unitOfWork));
            Repositories.Add(typeof(IService<Gender, GenderRepository>), new ServiceDB<Gender, GenderRepository>(unitOfWork));
            Repositories.Add(typeof(IService<User, UserRepository>), new ServiceDB<User, UserRepository>(unitOfWork));
            Repositories.Add(typeof(IService<Information, InformationRepository>), new ServiceDB<Information, InformationRepository>(unitOfWork));

            //CategoryService = new ServiceDB<Category, CategoryRepository>(unitOfWork);
            //CityService = new ServiceDB<City, CityRepository>(unitOfWork);
            //GenderService = new ServiceDB<Gender, GenderRepository>(unitOfWork);
            //UserService = new ServiceDB<User, UserRepository>(unitOfWork);
            //InformationService = new ServiceDB<Information, InformationRepository>(unitOfWork);
        }

        public TEntity GetRepository<TEntity>() where TEntity: class
        {
            if (Repositories.ContainsKey(typeof(TEntity)))
                return (TEntity)Repositories[typeof(TEntity)];
            else
                return (TEntity)null;
        }
    }
}
