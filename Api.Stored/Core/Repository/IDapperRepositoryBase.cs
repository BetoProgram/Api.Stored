using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Api.Stored.Core.Repository
{
    public interface IDapperRepositoryBase<T>
    {
        Task Execute(string query, object parameters = null, CommandType commandType = 0);
        Task<IEnumerable<T>> Query(string query, object parameters = null, CommandType commandType = 0);
        T QuerySingle(string query, object parameters = null);
    }
}