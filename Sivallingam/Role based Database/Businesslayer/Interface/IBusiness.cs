using Role_Entity.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Interface
{
    public interface IBusiness
    {
        public Task<object> POST(Admin details);
    }
}
