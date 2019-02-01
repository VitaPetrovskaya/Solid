using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public class Service
    {
        private readonly string _connectionString;
        protected readonly SqlConnection _sqlConnection;

        public Service(string connectionString)
        {
            _connectionString = connectionString;
            //_sqlConnection = new SqlConnection(_connectionString);
        }

        public Service()
        {
            _connectionString = "[connectionString]";
            //_sqlConnection = new SqlConnection(_connectionString);
        }

        public IEntity Save(IEntity entity)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        _sqlConnection.Open();
                        //perform Save
                        _sqlConnection.Close();
                        return entity;
                    }
                    catch
                    {
                        if (i == 2)
                            throw;
                    }
                }
                throw new Exception("Ex");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<IEntity> ReadAll()
        {
            _sqlConnection.Open();
            //perform Save
            _sqlConnection.Close();
            return new List<IEntity>();
        }

    }
}
