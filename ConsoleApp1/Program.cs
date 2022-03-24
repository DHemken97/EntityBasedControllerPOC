using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = new User { Name = "Bob2" };
            SqlRepository<User>.ConnectionString = "Data Source=localhost;Initial Catalog=Test;Integrated Security=True";
            
            var id = u.Create();
            var u2 = Extensions.GetEntityById<User>(id);

        }
    }
    class User:Entity
    {
        public string Name { get; set; }
    }
}
