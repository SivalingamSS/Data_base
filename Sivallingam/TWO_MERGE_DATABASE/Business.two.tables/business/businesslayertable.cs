using Business.two.tables.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TWO_TABLE_DTO.VIEWMODEL;
using TWO_TABLES_DATA.Interface;

namespace Business_two_tables_business
{
    public class businesslayertable : Ibusinesslayertable
    {
        private readonly Idatalayer _datalayertable;
        public businesslayertable(Idatalayer datalayertable)
        {
            _datalayertable = datalayertable;
        }
        public Task<object> POST(VIEWDETAILS details)
        {
            var post = _datalayertable.POST(details);
            return post;
        }
        public List<VIEWDETAILS> GET()
        {
            var get = _datalayertable.GET();
            return get;
        }
        public List <VIEWDETAILS> PUT(VIEWDETAILS details)
        {
            var put = _datalayertable.PUT(details);
            return put;
        }
        public List<VIEWDETAILS> DELETE(VIEWDETAILS details)
        {
            var put = _datalayertable.DELETE(details);
            return put;
        }


    }
}
