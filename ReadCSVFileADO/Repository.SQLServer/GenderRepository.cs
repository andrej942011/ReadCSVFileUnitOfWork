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
    public class GenderRepository:Repository<Gender>, IGenderRepository
    {
        public GenderRepository(SqlConnection context, SqlTransaction transaction) : base(context, transaction)
        { }

        public Gender Get(int id)
        {
            Gender gender = new Gender();
            string query = "SELECT * FROM [dbo].[Genders]" +
                           "WITH(NOLOCK)" +
                           "WHERE [Genders].[GenderId] = @genderId";

            gender = ExecuteReaderFirst(query, new SqlParameter[] { new SqlParameter("@genderId", id) });
            return gender;
        }

        public Gender GetName(string name)
        {
            string query = "SELECT * FROM [dbo].[Genders]" +
                           "WITH(NOLOCK)" +
                           "WHERE [Genders].[GenderName] = @name";

            return ExecuteReaderFirst(query, new SqlParameter[] { new SqlParameter("@name", name) });
        }

        public IEnumerable<Gender> GetAll()
        {
            string query = "SELECT * FROM [dbo].[Genders]" +
                           "WITH(NOLOCK)";
            return ExecuteReader(query, new SqlParameter[] { });
        }

        public void Create(Gender t)
        {
            var item1 = GetName(t.GenderName);
            if(item1.GenderId == 0)
            {
                var query = "INSERT INTO [dbo].[Genders](GenderName) OUTPUT INSERTED.[GenderId] VALUES ( @name)";
                var command = CreateCommand(query);
                command.Parameters.AddWithValue("@name", t.GenderName);

                t.GenderId = Convert.ToInt32(command.ExecuteScalar());
            }
            else
            {
                t.GenderId = item1.GenderId;
            }
        }
        public void Remove(Gender t)
        {
            throw new NotImplementedException();
        }

        public void Update(Gender t)
        {
            throw new NotImplementedException();
        }

        
    }
}
