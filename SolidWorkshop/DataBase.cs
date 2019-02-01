using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public class DataBase
    {
        private readonly string _connectionString;

        protected readonly SqlConnection _sqlConnection;

        public DataBase(string connectionString = "[connectionString]")
        {
            _connectionString = connectionString;
            _sqlConnection = new SqlConnection(_connectionString);
        }

        public SqlConnection Connection
        {
            get
            {
                return _sqlConnection;
            }
        }
    }
}
