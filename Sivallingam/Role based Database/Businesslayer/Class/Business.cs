using Businesslayer.Interface;
using Datalayer.Interface;
using Role_Entity.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Class
{
    public class Business : IBusiness
    {
        private readonly IDatalayer _idatalayer;
        public Business (IDatalayer idatalayer)
        {
            _idatalayer = idatalayer;
        }
        public Task<object> POST(Admin details)
        {
            var post = _idatalayer.POST(details);
            return post;
        }

    }
}
