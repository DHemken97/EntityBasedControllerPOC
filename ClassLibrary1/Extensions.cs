using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Extensions
    {
        public static long Create<TEntity>(this TEntity e) where TEntity:Entity
        {
            var SqlRepository = new SqlRepository<TEntity>();
            return SqlRepository.Create(e);
        }
        public static TEntity GetEntityById<TEntity>(long id) where TEntity : Entity
        {

            var SqlRepository = new SqlRepository<TEntity>();
            return SqlRepository.Get(id);
        }
    }
}
