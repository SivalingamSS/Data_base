using JsontaskRevision.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Amqp.Framing;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace JsontaskRevision.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("I find batters")]
        public object getbatters()
        {
            string str = System.IO.File.ReadAllText(@"H:\Sivallingam\JsontaskRevision\JsontaskRevision\jsconfig.json");
            List <Root> file = JsonConvert.DeserializeObject<List<Root>>(str);
            // string name = JsonConvert.SerializeObject(file[1]);
           List<Batter> name = new List<Batter>();
            foreach (var root in file)
            {
                foreach (var item in root.batters.batter)
                {
                    name.Add(item);
                }
            }
           
            return name ;
        }

        [HttpGet("employee")]
        public object get()
        {
            string name = System.IO.File.ReadAllText(@"H:\Sivallingam\JsontaskRevision\JsontaskRevision\jsconfig1.json");
            List<Employee> value = JsonConvert.DeserializeObject<List<Employee>>(name);
            List<Employee> media = new List<Employee>();
         
            foreach(var root in value)
            {
               // root.Gender = root.Gender == "0" ? Gender.male.ToString():root.Gender=="1"?Gender.female.ToString():Gender.others.ToString();
                if (root.Gender == "0")
                {
                    root.Gender = Gender.male.ToString();
                    media.Add(root);
                }
                else
                {
                    root.Gender = Gender.female.ToString();
                    media.Add(root);
                }
              // media.Add(root);
            }
            return media ;
        }

    }
}