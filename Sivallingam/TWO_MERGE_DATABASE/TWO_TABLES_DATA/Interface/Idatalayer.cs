using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWO_TABLE_DTO.VIEWMODEL;

namespace TWO_TABLES_DATA.Interface
{
    public interface Idatalayer
    {
        public Task<object> POST(VIEWDETAILS details);
        public List<VIEWDETAILS> GET();
        public List<VIEWDETAILS> PUT(VIEWDETAILS details);
        public List<VIEWDETAILS> DELETE(VIEWDETAILS details);
    
    }
}
