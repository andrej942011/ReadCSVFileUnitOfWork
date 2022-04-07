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
    public class CategoryRepository:Repository<Category>, ICategoryRepository
    {

        public CategoryRepository(SqlConnection context, SqlTransaction transaction):base(context, transaction)
        { }


        public Category Get(int id)
        {
            Category category = new Category();
            string query = "SELECT * FROM [dbo].[Categories]" +
                           "WITH(NOLOCK)" +
                           //"LEFT JOIN [dbo].[Users]" +
                           //"ON [Categories].[CategoryId] = [Users].[CategoryId]" +
                           "WHERE [Categories].[CategoryId] = @categoryId";

            category = ExecuteReaderFirst(query, new SqlParameter[] { new SqlParameter("@categoryId", id) });
            return category;
        }

        public Category GetName(string name)
        {
            Category category = new Category();
            string query = "SELECT * FROM [dbo].[Categories]" +
                           "WITH(NOLOCK)" +
                           //"LEFT JOIN [dbo].[Users]" +
                           //"ON [Categories].[CategoryId] = [Users].[CategoryId]" +
                           "WHERE [Categories].[CategoryName] = @name";

            category = ExecuteReaderFirst(query, new SqlParameter[] { new SqlParameter("@name", name) });

            return category;
        }

        public IEnumerable<Category> GetAll()
        {
            string query = "SELECT * FROM [dbo].[Categories] WITH(NOLOCK)";
            return ExecuteReader(query, new SqlParameter[] { });

            //var result = new List<Category>();
            //var command = CreateCommand("SELECT * FROM [dbo].[Categories] WITH(NOLOCK)");
            //using(var reader = command.ExecuteReader())
            //{
            //    var t = ConvertToTEntityes(reader);
            //    result = t;
            //    //while (reader.Read())
            //    //{
            //    //    result.Add(new Category
            //    //    {
            //    //        CategoryId = Convert.ToInt32(reader["CategoryId"]),
            //    //        CategoryName = reader["CategoryName"].ToString()
            //    //    });
            //    //}
            //}
            //return result;
        }

        public void Create(Category t)
        {
            //Проверка на наличие дублей в БД
            var item1 = GetName(t.CategoryName);
            if(item1.CategoryId == 0)
            {
                var query = "INSERT INTO [dbo].[Categories](CategoryName) OUTPUT INSERTED.[CategoryId] VALUES ( @name)";
                var command = CreateCommand(query);
                command.Parameters.AddWithValue("@name", t.CategoryName);

                t.CategoryId = Convert.ToInt32(command.ExecuteScalar());
                Console.WriteLine(t.CategoryId);
            }
            else
            {
                t.CategoryId = item1.CategoryId;
            }
        }
        public void Remove(Category t)
        {
            var command =
                CreateCommand("DELETE FROM [dbo].[Categories] WHERE [CategoryId] = @categoryId");
            command.Parameters.AddWithValue("@categoryId", t.CategoryId);

            command.ExecuteNonQuery();
        }

        public void Update(Category t)
        {
            var query = "UPDATE [dbo].[Categories] SET [CategoryName] = @name WHERE [CategoryId] = @categoryId";
            var command = CreateCommand(query);
            command.Parameters.AddWithValue("@name", t.CategoryName);
            command.Parameters.AddWithValue("@categoryId", t.CategoryId);

            command.ExecuteNonQuery();
        }

        
    }
}
