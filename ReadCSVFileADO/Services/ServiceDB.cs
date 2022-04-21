using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer;
using ReadCSVFileADO.RepositorySQLServer.Interface;
using ReadCSVFileADO.Services.Interface;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.UnitOfWorkSQLServer;
using System.Data;

namespace ReadCSVFileADO.Services
{
    public class ServiceDB<T, TypeRepo>: IService<T, TypeRepo> where T: class
    {
        private IUnitOfWork _unitOfWork;
        public ServiceDB(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<T> ExecuteReader(string query, SqlParameter[] sqlParameters)
        {
            List<T> resturns = new List<T>();
            using (var context = _unitOfWork.Create())
            {
                var result1 = CallMethod(context, "ExecuteReader", new object[] { query, sqlParameters }, typeof(TypeRepo));
                resturns = (List<T>) result1;
            }

            return resturns;
        }
        public void Create(T model)
        {
            using (var context = _unitOfWork.Create())
            {
                var result1 = CallMethod(context, "Create", new object[] { model }, typeof(TypeRepo));
                context.SaveChanges();
            };
        }

        public void Delete(T model) //No Test
        {
            using (var context = _unitOfWork.Create())
            {
                CallMethod(context, "Remove", new object[] { model }, typeof(TypeRepo));
                context.SaveChanges();
            };
        }

        public T Get(int id)
        {
            using(var context = _unitOfWork.Create())
            {
                var result1 = CallMethod(context, "Get", new object[] {id}, typeof(TypeRepo));
                return (T)result1;
            };
        }

        public T GetName(string name)
        {
            using (var context = _unitOfWork.Create())
            {
                var result1 = CallMethod(context, "GetName", new object[] { name }, typeof(TypeRepo));
                return (T)result1;
            };
        }

        public IEnumerable<T> GetAll()
        {
            using (var context = _unitOfWork.Create())
            {
                var result1 = CallMethod(context, "GetAll", null, typeof(TypeRepo));
                return (IEnumerable<T>) result1;
            }

        }

        public DataTable ExecuteReaderTable(string query, SqlParameter[] sqlParameters = null)
        {
            using (var context = _unitOfWork.Create())
            {
                var result1 = CallMethod(context, "ExecuteReaderTable", new object[] { query, sqlParameters}, typeof(TypeRepo));
                return (DataTable)result1;
            }
        }

        public void Update(T model)
        {
            using (var context = _unitOfWork.Create())
            {
                var result1 = CallMethod(context, "Update", new object[] { model }, typeof(TypeRepo));
                context.SaveChanges();
            }
        }

        private object CallMethod(IUnitOfWorkAdapter adapter, string nameMethod, object[] param, Type repositoryType)
        {
            var metods = repositoryType.GetMethods();
            var selectionMetods = metods.Where(m => m.Name == nameMethod);

            var metod = selectionMetods.First();
            Console.WriteLine(metod.Name);

            var instenceOfType = Activator.CreateInstance(repositoryType, new object[] { adapter._context, adapter._transaction });
            return  metod.Invoke(instenceOfType, param);
        }

        
    }
}
