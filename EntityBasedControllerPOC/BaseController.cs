using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EntityBasedControllerPOC
{
    public class BaseController<TEntity>: ApiController where TEntity:Entity
    {
        public virtual TEntity Create([FromBody]TEntity e)
        {
            var id = e.Create();
            return Get(id);
        }
        public virtual TEntity Get(long id)
        {
            return Extensions.GetEntityById<TEntity>(id);
        }
    }
}