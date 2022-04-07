using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer.Interface;

namespace ReadCSVFileADO.RepositorySQLServer
{
    public class CityRepository:Repository<City>, ICityRepository
    {
        public CityRepository(SqlConnection context, SqlTransaction transaction) : base(context, transaction)
        { }

        public City Get(int id)
        {
            City city = new City();
            string query = "SELECT * FROM [dbo].[Cities]" +
                           "WITH(NOLOCK)" +
                           //"LEFT JOIN [dbo].[Users]" +
                           //"ON [Cities].[CityId] = [Users].[CityId]" +
                           "WHERE [Cities].[CityId] = @cityId";

            city = ExecuteReaderFirst(query, new SqlParameter[] { new SqlParameter("@cityId", id) });

            return city;
        }

        public City GetName(string name)
        {
            City city = new City();
            string query = "SELECT * FROM [dbo].[Cities]" +
                           "WITH(NOLOCK)" +
                           "WHERE [CityName] = @name";

            city = ExecuteReaderFirst(query, new SqlParameter[] { new SqlParameter("@name", name) });

            return city;
        }

        public IEnumerable<City> GetAll()
        {
            string query = "SELECT * FROM [dbo].[Cities]" +
                           "WITH(NOLOCK)";
            return ExecuteReader(query, new SqlParameter[] { });
        }

        public void Create(City t)
        {
            //Проверка на наличие дублей в БД
            var item1 = GetName(t.CityName);
            if (item1.CityId == 0 && t.CityName != "") //""
            {
                var query = "INSERT INTO [dbo].[Cities](CityName) OUTPUT INSERTED.[CityId] VALUES ( @name)";
                var command = CreateCommand(query);
                command.Parameters.AddWithValue("@name", t.CityName);

                t.CityId = Convert.ToInt32(command.ExecuteScalar());
                Console.WriteLine(t.CityId);
            }
            else
            {
                t.CityId = item1.CityId;
            }
        }

        public void Remove(City t)
        {
            throw new NotImplementedException();
        }

        public void Update(City t)
        {
            throw new NotImplementedException();
        }

        
    }
}
