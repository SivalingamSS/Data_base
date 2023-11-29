using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role_Entity.Dbcontext
{
    public class Admin
    {
        public int Admin_id { get; set; }
        public string Admin_name { get; set;}
        public int Admin_Age { get; set;}
        public string Admin_password { get; set;}
        public string Admin_Address { get; set;}
        public string Admin_Gender { get; set;}

    }
    public class student
    {
        public int student_id { get; set; }
        public string student_name { get; set; } 
        public int student_Age { get; set;}
        public string student_Password { get; set;}
        public string student_roll { get;set;}
        public string student_Address { get; set;}
        public string student_Gender { get; set;}

    }
    public class teacher
    {
        public int teacher_id { get; set; }
        public string teacher_name { get;set; }
        public int teacher_age { get; set;}
        public string teacher_password { get;set;}
        public string teacher_address { get; set;}
        public string teacher_gender { get; set;}
    }
}
