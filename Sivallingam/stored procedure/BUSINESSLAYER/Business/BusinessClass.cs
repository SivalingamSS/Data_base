using BUSINESSLAYER.Interface;
using DATALAYER.Interface;
using SPStore_DTO.viewmodal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESSLAYER.Business
{
    public class BusinessClass : IBusinessInterface
    {
        private readonly IDataInterface _IdataInterface;
        public BusinessClass (IDataInterface businessClass)
        {
            _IdataInterface = businessClass;
        }
        public Task<object> GET()
        {
            var emp = _IdataInterface.GET();
            return emp;
        }
        public Task<object> POST(ViewModal details)
        {
            var emp = _IdataInterface.POST(details);
            return emp;
        }
        public Task<object> Update(ViewModal Update_details)
        {
            var emp = _IdataInterface.Update(Update_details);
            return emp;
        }
        public  Task<int> Delete(int KAPILAN_ID)
        {
            var emp = _IdataInterface.Delete(KAPILAN_ID);
            return emp;
        }
    }
    
}
