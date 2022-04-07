using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.Services;

namespace ReadCSVFileADO.View.BL
{
    public class InformationUsersBL
    {
        private ServicesDB servicesDb;
        public InformationUsersBL(ServicesDB servicesDb)
        {
            this.servicesDb = servicesDb;
        }

        public DataTable GetInformationId(int id)
        {
            string query = "SELECT * FROM [dbo].[Users]" +
                           "WITH(NOLOCK)" +
                           "LEFT JOIN [dbo].[Categories]" +
                           "ON [Users].[CategoryId] = [Categories].[CategoryId]" +
                           "LEFT JOIN [dbo].[Genders]" +
                           "ON [Users].[GenderId] = [Genders].[GenderId]" +
                            "LEFT JOIN [dbo].[Cities]" +
                            "ON [Users].[CityId] = [Cities].[CityId]" +
                            "WHERE [InformationId] = @Id";

            return  servicesDb.UserService.ExecuteReaderTable(query, new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Id", id) });//GetAll();
        }
    }
}
