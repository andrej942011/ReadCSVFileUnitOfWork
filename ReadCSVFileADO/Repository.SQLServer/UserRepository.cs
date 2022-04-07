using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer.Interface;

namespace ReadCSVFileADO.RepositorySQLServer
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(SqlConnection context, SqlTransaction transaction) : base(context, transaction)
        {}

        public User Get(int id)
        {
            User user;
            string query = "SELECT * FROM [dbo].[Users]" +
                           "WITH(NOLOCK)" +
                           "LEFT JOIN [dbo].[Categories]" +
                           "ON [Users].[CategoryId] = [Categories].[CategoryId]" +
                           "LEFT JOIN [dbo].[Genders]" +
                           "ON [Users].[GenderId] = [Genders].[GenderId]" +
                           "LEFT JOIN [dbo].[Cities]" +
                           "ON [Users].[CityId] = [Cities].[CityId]" +
                           "WHERE Id = @Id";

            var command = CreateCommand(query);//SELECT * FROM [dbo].[Users] WITH(NOLOCK) WHERE Id = @Id
            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader())
            {
                user = ConvertToTEntityes(reader).First();
                //reader.Read();

                //user = ConvertToTEntity(reader); //MappingUser(reader);
            }

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            var result = new List<User>();
            string query = "SELECT * FROM [dbo].[Users]" +
                           "WITH(NOLOCK)" +
                           "LEFT JOIN [dbo].[Categories]" +
                           "ON [Users].[CategoryId] = [Categories].[CategoryId]" +
                           "LEFT JOIN [dbo].[Genders]" +
                           "ON [Users].[GenderId] = [Genders].[GenderId]" +
                            "LEFT JOIN [dbo].[Cities]" +
                            "ON [Users].[CityId] = [Cities].[CityId]";

            var command = CreateCommand(query);
            using (var reader = command.ExecuteReader())
            {
                //result = ConvertToTEntityes(reader); //Null DateTime не преобразуется!
                while (reader.Read())
                {
                    result.Add(new User()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Phone = (reader["Phone"].ToString()),
                        LastName = reader["LastName"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        MiddleName = reader["MiddleName"].ToString(),
                        DateOfBirth = reader["DateOfBirth"].ToString(),
                        //DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        GenderName = reader["GenderName"].ToString(),
                        CityName = reader["CityName"].ToString(),
                        CategoryName = reader["CategoryName"].ToString()
                    });
                }
            }

            return result;
        }

        public void Create(User t) //проблемы с записью null, значений в бд!!
        {
            try
            {
                var query = "INSERT INTO [dbo].[Users]" +
                            "([Phone], [LastName], [FirstName], [MiddleName], [CategoryId], [GenderId], [CityId], [DateOfBirth], [InformationId])" +
                            "OUTPUT INSERTED.[Id]" +
                            "VALUES (@Phone, @LastName, @FirstName, @MiddleName, @CategoryId, @GenderId, @CityId, @DateOfBirth, @InformationId)";
                var command = CreateCommand(query);
                //command.Parameters.AddWithValue("@Phone", t.Phone);
                command.Parameters.AddWithValue("@Phone", t.Phone == "" ? DBNull.Value : (object)t.Phone); //"0"
                command.Parameters.AddWithValue("@LastName", t.LastName == "" ? DBNull.Value: (object)t.LastName) ;
                command.Parameters.AddWithValue("@FirstName", t.FirstName == "" ? DBNull.Value: (object)t.FirstName);
                command.Parameters.AddWithValue("@MiddleName", t.MiddleName == "" ? DBNull.Value: (object)t.MiddleName);
                command.Parameters.AddWithValue("@CategoryId", t.CategoryId == 0 ? DBNull.Value: (object)t.CategoryId);
                //command.Parameters.AddWithValue("@GenderId", t.GenderId);
                command.Parameters.AddWithValue("@GenderId", t.GenderId == 0 ? DBNull.Value : (object)t.GenderId);
                //command.Parameters.AddWithValue("@CityId", t.CityId);
                command.Parameters.AddWithValue("@CityId", t.CityId == 0 ? DBNull.Value : (object)t.CityId);
                //command.Parameters.AddWithValue("@DateOfBirth", t.DateOfBirth);
                command.Parameters.AddWithValue("@DateOfBirth", t.DateOfBirth == null ? DBNull.Value : (object)t.DateOfBirth);
                command.Parameters.AddWithValue("@InformationId", t.InformationId);

                t.Id = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }

        public void Remove(User id)
        {
            throw new NotImplementedException();
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }

        public User GetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
