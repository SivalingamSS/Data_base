using System.ComponentModel.DataAnnotations;

namespace Datetime_overlapmethod.model
{
    public class MODEL
    {
        [Key]
        public int DATE_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
   
}
