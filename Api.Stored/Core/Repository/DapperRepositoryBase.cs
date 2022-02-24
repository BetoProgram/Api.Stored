using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Repository
{
    public class DapperRepositoryBase<T> : IDapperRepositoryBase<T> where T : class
    {
        private readonly IConfiguration _configuration;
        private string connectionName = "ConnectionDefault";
        private string connectionString;

        public string ConnectionName
        {
            get { return connectionName; }
            set { connectionName = value; }
        }

        public DapperRepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString(ConnectionName);
        }

        public async Task<IEnumerable<T>> Query(string query, object parameters = null, CommandType commandType = default)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return await conn.QueryAsync<T>(query, parameters);
            }
                
        }

        public T QuerySingle(string query, object parameters = null)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return conn.QuerySingle<T>(query, parameters);
            }
                
        }

        public void Execute(string query, object parameters = null, CommandType commandType = default)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    conn.Execute(query, parameters);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
                
        }
    }
}
