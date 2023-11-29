using Datalayer.Interface;
using Role_Entity.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Class
{
    public class Dataclass : IDatalayer
    {
        private readonly AdminDbContext  _adminDbContext;
        public Dataclass(AdminDbContext adminDbContext)
        {
            _adminDbContext = adminDbContext;
        }
        public Task<object> POST(Admin details)
        {
           
        }
    }
}
