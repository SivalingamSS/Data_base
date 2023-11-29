using Role_Entity.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Interface
{
    public interface IDatalayer
    {
        public Task<object> POST(Admin details);
    }
}
