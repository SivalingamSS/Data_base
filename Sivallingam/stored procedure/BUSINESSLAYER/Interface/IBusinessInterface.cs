using SPStore_DTO.viewmodal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESSLAYER.Interface
{
    public interface IBusinessInterface
    {
        public  Task<object> GET(); 
        public Task<object> POST(ViewModal details);
        public Task<object> Update(ViewModal Update_details);
        public Task<int> Delete(int KAPILAN_ID);
    }
}
