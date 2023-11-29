using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWO_TABLE_DTO.VIEWMODEL;

namespace Business.two.tables.Interface
{
    public interface Ibusinesslayertable
    {
        public Task<object> POST(VIEWDETAILS details);
        public List<VIEWDETAILS> GET();
        public List<VIEWDETAILS> PUT(VIEWDETAILS details);
        public List<VIEWDETAILS> DELETE(VIEWDETAILS details);
    }
}
