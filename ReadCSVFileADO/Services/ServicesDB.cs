using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public Dictionary<Type, object> Repositories { get; set; }
        private Dictionary<Type, object> _services;

        private IUnitOfWork _unitOfWork;

        public ServicesDB(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            //Repositories = new Dictionary<Type, object>();

            //Repositories.Add(typeof(IService<Category, CategoryRepository>), new ServiceDB<Category, CategoryRepository>(unitOfWork));
            //Repositories.Add(typeof(IService<City, CityRepository>), new ServiceDB<City, CityRepository>(unitOfWork));
            //Repositories.Add(typeof(IService<Gender, GenderRepository>), new ServiceDB<Gender, GenderRepository>(unitOfWork));
            //Repositories.Add(typeof(IService<User, UserRepository>), new ServiceDB<User, UserRepository>(unitOfWork));
            //Repositories.Add(typeof(IService<Information, InformationRepository>), new ServiceDB<Information, InformationRepository>(unitOfWork));
        }

        public IService<TEntity, TRepository> GetService<TEntity, TRepository>() where TEntity : class
        {
            if(_services is null)
                _services = new Dictionary<Type, object>();

            var serviceDB = new ServiceDB<TEntity, TRepository>(_unitOfWork);

            //Type type1 = typeof(ServiceDB<TEntity, TRepository>);

            //var serviceType = Assembly
            //    .GetExecutingAssembly()
            //    .GetTypes();
            
            //    //.First(type => type.FullName == "ReadCSVFileADO.Services.ServiceDB"); //"ReadCSVFileADO.RepositorySQLServer.InformationRepository"

            //var serviceInstance = Activator.CreateInstance(type1, new object[] { _unitOfWork }) ??
            //                         throw new Exception($"Cannot create instance of {type1.Name}!");

            return serviceDB;
        }

        public object GetRepository<TEntity, TRepository>() where TEntity: class
        {
            if(Repositories is null)
                Repositories = new Dictionary<Type, object>();

            Type entityType = typeof(TEntity);
            if (Repositories.ContainsKey(entityType))
                return Repositories[typeof(TEntity)];
            else
                return null;

            //// Try find type of repository for specified entity.
            //var repositoryType = Assembly
            //    .GetExecutingAssembly()
            //    .GetTypes()
            //    .First(type =>
            //        type.BaseType != null &&
            //    type.BaseType.Equals(typeof(ServiceDB<TEntity, TRepository>))); //type.BaseType.Equals(typeof(Repository<TEntity>)));

            //var repositoryInstance = Activator.CreateInstance(repositoryType, new object[] {_unitOfWork}) ??
            //                         throw new Exception($"Cannot create instance of {repositoryType.Name}!");

            //Repositories[entityType] = repositoryInstance;
            //return repositoryInstance;

            //if (Repositories.ContainsKey(typeof(TEntity)))
            //    return (TEntity)Repositories[typeof(TEntity)];
            //else
            //    return (TEntity)null;
        }
    }
}
