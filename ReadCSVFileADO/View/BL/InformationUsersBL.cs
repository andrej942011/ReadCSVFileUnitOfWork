using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer;
using ReadCSVFileADO.RepositorySQLServer.Interface;
using ReadCSVFileADO.Services;
using ReadCSVFileADO.Services.Interface;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;

namespace ReadCSVFileADO.View.BL
{
    public class InformationUsersBL
    {
        private IInformationRepository informationRepository;


        public InformationUsersBL(IInformationRepository repository)
        {
            this.informationRepository = repository;
        }

        public DataTable GetInformationId(int id)
        {
            //var serviceUser = servicesDb.GetRepository<IService<User, UserRepository>>();

            string query = "SELECT * FROM [dbo].[Users]" +
                           "WITH(NOLOCK)" +
                           "LEFT JOIN [dbo].[Categories]" +
                           "ON [Users].[CategoryId] = [Categories].[CategoryId]" +
                           "LEFT JOIN [dbo].[Genders]" +
                           "ON [Users].[GenderId] = [Genders].[GenderId]" +
                            "LEFT JOIN [dbo].[Cities]" +
                            "ON [Users].[CityId] = [Cities].[CityId]" +
                            "WHERE [InformationId] = @Id";

            return informationRepository.ExecuteReaderTable(query, new SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Id", id)});
        }
    }
}
