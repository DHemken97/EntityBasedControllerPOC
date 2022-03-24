using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class SqlRepository<TEntity> where TEntity : Entity
    {
        public static string ConnectionString;
        private SqlConnection connection;

        public SqlRepository()
        {
            connection = new SqlConnection(ConnectionString);
        }

        public long Create(TEntity entity)
        {
            var id = connection.Insert(entity);
            return id;
        }

        public TEntity Get(long id)
        {
            return connection.Get<TEntity>(id);
        }
    }
}
