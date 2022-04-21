using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.ReadFile.Document;
using ReadCSVFileADO.ReadFile.Interface;
using ReadCSVFileADO.ReadFile.Models;
using ReadCSVFileADO.RepositorySQLServer;
using ReadCSVFileADO.Services;
using ReadCSVFileADO.Services.Interface;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;
using ReadCSVFileADO.View.Inferface;

namespace ReadCSVFileADO.View.BL
{
    public class CreateInformationBL: IUpdateForm
    {
        private ServicesDB servicesDb;
        public List<ContactModel> models;
        private Information information;
        private string filePatch;
        private CreateInformationForm form;
        public CreateInformationBL(ServicesDB servicesDb, CreateInformationForm form)
        {
            this.servicesDb = servicesDb;
            models = new List<ContactModel>();
            this.form = form;
        }

        public void OpenCsvFile(string filePatch)
        {
            this.filePatch = filePatch;
            IReadDocument readDocument = new CSVDocument(filePatch);
            models = readDocument.ReadFile();
        }

        public void CreateInformation(String tbComment)
        {
            if (models.Count > 0)
            {
                //1) создадим запись в бд(информация)
                information = new Information()
                {
                    Comment = tbComment,
                    DateCreate = DateTime.Now,
                    FilePath = filePatch
                };
                var serviceInformation = servicesDb.GetRepository<IService<Information, InformationRepository>>();
                serviceInformation.Create(information);
                //servicesDb.InformationService.Create(information);

                int itemCount = 0;
                int itemCountMax = models.Count;
                foreach (var item in models)
                {
                    ContactModelToSQL(item, information);

                    form.UpdateProcessWriting((itemCount * 100) / itemCountMax);
                    itemCount++;
                }
                form.UpdateProcessWriting(itemCount);
            }
            else
            {
                MessageBox.Show("CSV файл не загружен");
            }
        }

        private void ContactModelToSQL(ContactModel contactModel, Information information)
        {
            var category = new Category()
            {
                CategoryName = contactModel.Category
            };
            var serviceCategory = servicesDb.GetRepository<IService<Category, CategoryRepository>>();
            serviceCategory.Create(category);
            //servicesDb.CategoryService.Create(category);

            var city = new City()
            {
                CityName = contactModel.City
            };
            var serviceCity = servicesDb.GetRepository<IService<City, CityRepository>>();
            serviceCity.Create(city);
            //servicesDb.CityService.Create(city);

            var gender = new Gender()
            {
                GenderName = contactModel.Gender
            };
            var serviceGender = servicesDb.GetRepository<IService<Gender, GenderRepository>>();
            serviceGender.Create(gender);
            //servicesDb.GenderService.Create(gender);

            User user = new User()
            {
                Phone = contactModel.Phone,
                LastName = contactModel.LastName,
                FirstName = contactModel.FirstName,
                MiddleName = contactModel.MiddleName,
                DateOfBirth = contactModel.DateOfBirth.ToString(),
                CategoryId = category.CategoryId,
                CityId = city.CityId,
                GenderId = gender.GenderId,
                InformationId = information.InformationId
            };
            var serviceUser = servicesDb.GetRepository<IService<User, UserRepository>>();
            serviceUser.Create(user);
            //servicesDb.UserService.Create(user);
        }

        public void UpdateProcessWriting(int count)
        {
            throw new NotImplementedException();
        }
    }
}
