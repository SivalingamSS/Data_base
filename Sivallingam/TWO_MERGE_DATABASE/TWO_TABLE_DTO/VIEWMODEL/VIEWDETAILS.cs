using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWO_TABLE_DTO.VIEWMODEL
{
    public class VIEWDETAILS
    {
        [Key]
        public int KAPILAN_ID { get; set; }
        public string KAPILAN_NAME { get; set; }
        public string KAPILAN_DEPARTMENT { get; set; }
        public string KAPILAN_CITY { get; set; }
        public int SIVA_ID { get; set; }
        public int SIVA_AGE { get; set; }
        public string SIVA_GENDER { get; set; }

    }
}
