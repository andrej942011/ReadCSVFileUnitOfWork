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
    public class InformationRepository:Repository<Information>, IInformationRepository
    {
        public InformationRepository(SqlConnection context, SqlTransaction transaction) : base(context, transaction)
        { }


        public Information Get(int id)
        {
            Information information = new Information();
            string query = "SELECT * FROM [dbo].[Information]" +
                           "WITH(NOLOCK)" +
                           "WHERE [Information].[InformationId] = @informationId";
            var command = CreateCommand(query);
            command.Parameters.AddWithValue("@informationId", id);
            using(var reader = command.ExecuteReader())
            {
                var informations = ConvertToTEntityes(reader);
                information = informations.First();
            }

            return information;
        }
        public IEnumerable<Information> GetAll()
        {
            var result = new List<Information>();
            string query = "SELECT * FROM [dbo].[Information] WITH(NOLOCK)";
            var command = CreateCommand(query);
            using (var reader = command.ExecuteReader())
            {
                result = ConvertToTEntityes(reader);
                //while (reader.Read())
                //{
                //    result.Add(ConvertToTEntity(reader));
                //    //result.Add(MappingInformation(reader));
                //}
            }

            return result;
        }
        public void Create(Information t)
        {
            var query = "INSERT INTO [dbo].[Information]" +
                        "([DateCreate],[FilePath],[Comment])" +
                        "OUTPUT INSERTED.[InformationId]" +
                        "VALUES" +
                        "(@DateCreate, @FilePath, @Comment)";
            var command = CreateCommand(query);
            command.Parameters.AddWithValue("@DateCreate", t.DateCreate);
            command.Parameters.AddWithValue("@FilePath", t.FilePath);
            command.Parameters.AddWithValue("@Comment", t.Comment);

            t.InformationId = Convert.ToInt32(command.ExecuteScalar());
        }

        public void Remove(Information t)
        {
            throw new NotImplementedException();
        }

        public void Update(Information t)
        {
            throw new NotImplementedException();
        }

        public Information GetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
