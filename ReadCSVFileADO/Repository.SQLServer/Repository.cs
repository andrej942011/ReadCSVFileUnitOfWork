using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.RepositorySQLServer
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity : class
    {
        protected SqlConnection _context;
        protected SqlTransaction _sqlTransaction;
        public Repository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._sqlTransaction = transaction;
        }

        protected SqlCommand CreateCommand(string query)
        {
            return new SqlCommand(query, _context, _sqlTransaction);
        }

        public List<TEntity> ExecuteReader(string query, SqlParameter[] sqlParameters)
        {
            List<TEntity> results = new List<TEntity>();
            if (query == null) throw new ArgumentNullException("Нет SQL команды");

            var command = CreateCommand(query);
            if(sqlParameters.Length>0)
                command.Parameters.AddRange(sqlParameters);

            using (var reader = command.ExecuteReader())
            {
                results = ConvertToTEntityes(reader);
            }

            return results;
        }

        public DataTable ExecuteReaderTable(string query, SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            if (query == null) throw new ArgumentNullException("Нет SQL команды");

            var command = CreateCommand(query);
            if (sqlParameters.Length > 0)
                command.Parameters.AddRange(sqlParameters);

            using (var reader = command.ExecuteReader())
                dataTable.Load(reader);

            return dataTable;
        }

        public TEntity ExecuteReaderFirst(string query, SqlParameter[] sqlParameters)
        {
            Type type = typeof(TEntity);
            TEntity obj = (TEntity)Activator.CreateInstance(type);

            var resurns = ExecuteReader(query, sqlParameters);
            if (resurns.Count > 0)
                return resurns.First();
            else
                return obj;
        }

        protected List<TEntity> ConvertToTEntityes(SqlDataReader reader)  //Exeption на ненайденное имя!
        {
            List<TEntity> results = new List<TEntity>();
            Type type = typeof(TEntity);
            PropertyInfo[] properties = type.GetProperties();

            while (reader.Read())
            {
                TEntity obj = (TEntity)Activator.CreateInstance(type);
                foreach (PropertyInfo property in properties)
                {
                    try
                    {
                        var value = reader[property.Name];
                        if (value != null)
                        {
                            //Console.WriteLine($"{property.Name} - {value}");
                            property.SetValue(obj, Convert.ChangeType(value.ToString(), property.PropertyType));
                        }

                    }
                    catch { }
                }

                results.Add(obj);
            }

            return results;
        }

        public TEntity Get1(int id)
        {
            var command = CreateCommand("SELECT * FROM [dbo].[Categories] WITH(NOLOCK) WHERE [CategoryId] = @categoryId");
            command.Parameters.AddWithValue("@categoryId", id);
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                var tt = new Category
                {
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                    CategoryName = reader["Name"].ToString()
                };

                return (TEntity)(object)tt;//return (TEntity)(object)tt;
            }
        }

        
    }
}
