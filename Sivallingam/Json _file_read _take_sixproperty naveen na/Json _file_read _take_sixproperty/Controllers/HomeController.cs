using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using static Json__file_read__take_sixproperty.model.emp;
using Json__file_read__take_sixproperty.model;
using Json__file_read__take_sixproperty.model;
using method = Json__file_read__take_sixproperty.model.emp.method;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sakura.AspNetCore;

namespace Json__file_read__take_sixproperty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult get1(string? connum)
        {
            var emp = System.IO.File.ReadAllText(@"H:\Sivallingam\Json _file_read _take_sixproperty naveen na\Json _file_read _take_sixproperty\jsconfig.json");
            List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(emp);
            List<method> data = new List<method>();
            var items1 = roots.Where(r => r != null && r.ConfirmationNumber == connum)
           .Select(r => new method
           {
               confirnum = r.ConfirmationNumber,
               CompName = r.EnrollmentCustomer.CompanyName,
               BDate = r.EnrollmentCustomer.BirthDate,
               Paymode = r.EnrollmentCustomer.PaymentCategoryCode,
               utilityAC = r.EnrollmentCustomer.ServiceAccount.Select(s => s.UtilityAccountNumber).FirstOrDefault(),
               Contract = r.EnrollmentCustomer.ServiceAccount.Select(s => s.ContractSignedDate).FirstOrDefault(),
               enroll = r.EnrollmentCustomer.ServiceAccount.Select(s => s.EnrollmentHikariService).FirstOrDefault(),
               Divcode = r.DivisionCode,
               Credate = r.EnrollmentCustomer.CreateDate
           }).ToList();
            return Ok(items1);
        }
        [HttpGet("counum")]
        public IActionResult get2(string? connum)
        {
            var emp = System.IO.File.ReadAllText(@"H:\Sivallingam\Json _file_read _take_sixproperty naveen na\Json _file_read _take_sixproperty\jsconfig.json");
            List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(emp);
            List<method1> data = new List<method1>();
            var items1 = roots.Where(r => r != null && r.ConfirmationNumber == connum)
           .Select(r => new method1
           {
               confirnum = r.ConfirmationNumber,
               CompName = r.EnrollmentCustomer.CompanyName,
               BDate = r.EnrollmentCustomer.BirthDate,
               Paymode = r.EnrollmentCustomer.PaymentCategoryCode,
               Divcode = r.DivisionCode,
               Credate = r.EnrollmentCustomer.CreateDate
           }).ToList();
            return Ok(items1);
        }
        [HttpGet("Pagnation")]
        public  IActionResult get1(int? pageSize = 1)
        {
           
           int page = 1;
           var emp = System.IO.File.ReadAllText(@"H:\Sivallingam\Json _file_read _take_sixproperty naveen na\Json _file_read _take_sixproperty\jsconfig.json");
           List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(emp);
           var san = roots.Skip((int)(pageSize - 1)).Take((int)page).ToList();
           return Ok(san);

        }
      
    }
}
/*if (!string.IsNullOrEmpty(connum) == null)
{
    List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(emp);
    List<method> data = new List<method>();
    {
        var items = roots.Where(r => r.ConfirmationNumber == connum)
    .Select(r => new method
    {
        confirnum = r.ConfirmationNumber,
        CompName = r.EnrollmentCustomer.CompanyName,
        BDate = r.EnrollmentCustomer.BirthDate,
        Paymode = r.EnrollmentCustomer.PaymentCategoryCode,
        utilityAC = r.EnrollmentCustomer.ServiceAccount.Select(s => s.UtilityAccountNumber).FirstOrDefault(),
        Contract = r.EnrollmentCustomer.ServiceAccount.Select(s => s.ContractSignedDate).FirstOrDefault(),
        Divcode = r.DivisionCode,
        Credate = r.CreateDate
    }).ToList();
        data.Add(items);
    }
}
else
{
    List<Root> roots1 = JsonConvert.DeserializeObject<List<Root>>(emp);

    var items1 = roots1.Where(r => r.ConfirmationNumber == connum)
.Select(r => new method
{
   confirnum = r.ConfirmationNumber,
   CompName = r.EnrollmentCustomer.CompanyName,
   BDate = r.EnrollmentCustomer.BirthDate,
   Paymode = r.EnrollmentCustomer.PaymentCategoryCode,
   utilityAC = r.EnrollmentCustomer.ServiceAccount.Select(s => s.UtilityAccountNumber).FirstOrDefault(),
   Contract = r.EnrollmentCustomer.ServiceAccount.Select(s => s.ContractSignedDate).FirstOrDefault(),
   Divcode = r.DivisionCode,
   Credate = r.CreateDate
}).ToList();
}
return data;*/
/*
            var items = from c in roots.Select(s => s.ConfirmationNumber == connum).ToList()
                        from e in roots.Select(a => a.EnrollmentCustomer).ToList()
                        from s in roots.SelectMany(a => a.EnrollmentCustomer.ServiceAccount)
                        from r in roots.SelectMany(a => a.EnrollmentCustomer.ServiceAccount)
                        from w in roots.Select(a => a.DivisionCode)
                        from X in roots.Select(a => a.CreateDate)
                        where c
                        select new method
                        {
                            confirnum = c,
                            CompName = e.CompanyName,
                            BDate = e.BirthDate,
                            Paymode = e.PaymentCategoryCode,
                            utilityAC = s.UtilityAccountNumber,
                            Contract = s.ContractSignedDate,
                            Divcode = w,
                            Credate = X
                        }*/
/*
            var confirnum = roots.Select(a => a.ConfirmationNumber == connum).ToList();
            var CompanyName = roots.Select(a => a.EnrollmentCustomer.CompanyName).ToList();
            var BirthDate = roots.Select(a => a.EnrollmentCustomer.BirthDate).ToList();
            var paymode = roots.Select(a => a.EnrollmentCustomer.PaymentCategoryCode).ToList();
            var utilityAc = roots.Where(a => a.EnrollmentCustomer.ServiceAccount != null).SelectMany(a => a.EnrollmentCustomer.ServiceAccount.Select(a => a.UtilityAccountNumber).ToList());
            var contract = roots.Where(a => a.EnrollmentCustomer.ServiceAccount != null).SelectMany(a => a.EnrollmentCustomer.ServiceAccount.Select(a => a.ContractSignedDate).ToList());
            var Divcode = roots.Select(a => a.DivisionCode).ToList();
            var credate = roots.Select(a => a.CreateDate).ToList();*/
/*            for (int i = 0; i < CompanyName.Count - 1; i++)
            {
                data1.Add(new
                {
                    confirnum = confirnum[i],
                    ComName = CompanyName[i],
                    BDate = BirthDate[i],
                    Paymode = paymode[i],
                    Utility = utilityAc[i],
                    Contract = contract[i],
                    Div = Divcode[i],
                    credate = credate[i]
                });
            }*/
/*
            enrolement = new
            {
                confirnum,
                CompanyName,
                BirthDate,
                paymode,
                utilityAc,
                contract,
                Divcode,
                credate
            };
        */
//from c in roots.Select(a => a.ConfirmationNumber)
/* var sum = ( from c in roots 
            from e in roots.Select(a => a.EnrollmentCustomer)
            from s in roots.SelectMany(a => a.EnrollmentCustomer.ServiceAccount)
            from r in roots.SelectMany(a => a.EnrollmentCustomer.ServiceAccount)
            from w in roots.Select(a => a.DivisionCode)
            from X in roots .Select(a=>a.CreateDate)
             where c.ConfirmationNumber == "WE83127067"
             select new method
             {
               //confirnum1 = r.EnrollmentHikariService.ConfirmationNumber,
                 confirnum = c.ConfirmationNumber,
                 CompName = e.CompanyName,
                 BDate = e.BirthDate,
                 Paymode = e.PaymentCategoryCode,
                 utilityAC = s.UtilityAccountNumber,
                 Contract = s.ContractSignedDate,
                 Divcode= w,
                 Credate = X
             }).FirstOrDefault();*/
//   data.Add(sum);
//   return data;

/*  for (int i = 0; i < sum.Count - 1; i++)
  {
      data.Add(new method
      {
          confirnum = ConfirmationNumber[i],
          ComName = ComName[i],
          BDate = DOB[i],
          Paymode = Paymode[i],
          utilityAC = Utility[i],
          Contract = ContactSign[i],
          Div = Divison[i]
      });
  }*/
/*  var ConfirmationNumber = roots.Select(a => a.ConfirmationNumber).ToList();
  var ComName = roots.Select(a => a.EnrollmentCustomer.CompanyName).ToList();
  var DOB = roots.Select(a => a.EnrollmentCustomer.BirthDate).ToList();
  var Paymode = roots.Select(a => a.EnrollmentCustomer.PaymentCategoryCode).ToList();
  var Utility = roots.Where(a => a.EnrollmentCustomer.ServiceAccount != null).SelectMany(a => a.EnrollmentCustomer.ServiceAccount.Select(a => a.UtilityAccountNumber)).ToList();
  var ContactSign = roots.Where(a => a.EnrollmentCustomer.ServiceAccount != null).SelectMany(a => a.EnrollmentCustomer.ServiceAccount.Select(b => b.ContractSignedDate)).ToList();
  var Divison = roots.Select(a => a.DivisionCode).ToList();
  for (int i = 0; i < ConfirmationNumber.Count -1; i++)
  {
      data.Add(new method
      {
          confirnum = ConfirmationNumber[i],
          ComName =  ComName[i],
          BDate = DOB[i],
          Paymode = Paymode[i],
          utilityAC = Utility[i],
         Contract = ContactSign[i],
          Div = Divison[i]
      });
  }
  return data;*/
/*      }
  }
}
*/