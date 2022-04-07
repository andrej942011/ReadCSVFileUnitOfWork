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
        public IService<Category, CategoryRepository> CategoryService { get; set; }
        public IService<City, CityRepository> CityService { get; set; }
        public IService<Gender, GenderRepository> GenderService { get; set; }
        public IService<User, UserRepository> UserService { get; set; }
        public IService<Information, InformationRepository> InformationService { get; set; }

        public ServicesDB(IUnitOfWork unitOfWork)
        {
            CategoryService = new ServiceDB<Category, CategoryRepository>(unitOfWork);
            CityService = new ServiceDB<City, CityRepository>(unitOfWork);
            GenderService = new ServiceDB<Gender, GenderRepository>(unitOfWork);
            UserService = new ServiceDB<User, UserRepository>(unitOfWork);
            InformationService = new ServiceDB<Information, InformationRepository>(unitOfWork);
        }
    }
}
