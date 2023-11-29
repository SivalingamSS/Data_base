using System.Linq;
using System.Collections;
using System.Xml.Linq;

using Newtonsoft.Json;
using ConsoleApp1_json.modal;

namespace JsonReadEmployee_naveen_na
{
    class program
    {
        public static void Main()
        {
            var emp = System.IO.File.ReadAllText(@"H:\Sivallingam\ConsoleApp1_json\ConsoleApp1_json\jsconfig1.json");
            List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(emp);
             var data = new List<object>();
            int totalpagereview = 1;
            //  int pagenumber = 1;
            Console.WriteLine("enter the page number");


            if (int.TryParse(Console.ReadLine(), out int pagesize))
            {
                var ms = roots.Skip(pagesize - 1).Take(totalpagereview).ToList();
                foreach (var root in ms)
                {
                    data.Add(root);
                   
                }
                foreach (var num in data)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("enter the valid page number ");
            }
        }
    }
}