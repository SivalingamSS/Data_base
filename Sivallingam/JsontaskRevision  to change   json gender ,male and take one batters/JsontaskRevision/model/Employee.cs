using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace JsontaskRevision.model
{
    public class Employee 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Club { get; set; }
        public string Persona { get; set; }
        public string Crush { get; set; }
        public string BreastSize { get; set; }
        public string Strength { get; set; }
        public string Hairstyle { get; set; }
        public string Color { get; set; }
        public string Stockings { get; set; }
        public string Accessory { get; set; }
        public string ScheduleTime { get; set; }
        public string ScheduleDestination { get; set; }
        public string ScheduleAction { get; set; }
    }
    public enum Gender
    {
          male,
            female ,
            others
    }
}

