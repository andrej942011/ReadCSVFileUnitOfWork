using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.UnitOfWorkSQLServer
{
    public class UnitOfWorkSqlServerAdapter: IUnitOfWorkAdapter
    {
        public SqlConnection _context { get; set; }
        public SqlTransaction _transaction { get; set; }
        public IUnitOfWorkRepository Repositories { get; set; }

        public UnitOfWorkSqlServerAdapter(string connectionString)
        {
            _context = new SqlConnection(connectionString);
            _context.Open();

            _transaction = _context.BeginTransaction();
            Repositories = new UnitOfWorkSqlServerRepository(_context, _transaction);
        }

        public void SaveChanges()
        {
            _transaction.Commit();
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();

            if(_context !=null)
            {
                _context.Close();
                _context.Dispose();
            }

            Repositories = null;
        }
    }
}
