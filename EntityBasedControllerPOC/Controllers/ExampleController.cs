using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EntityBasedControllerPOC.Controllers
{
    
    public class ExampleController : BaseController<User>
    {

       
    }

    public class User : Entity
    {
        public string Name { get; set; }
    }

}
