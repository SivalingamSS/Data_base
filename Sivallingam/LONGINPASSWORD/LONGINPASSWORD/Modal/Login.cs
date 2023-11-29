using System.ComponentModel.DataAnnotations;

namespace LONGINPASSWORD.Modal
{
    public class student
    {
            [Key]
            public int user_Id { get; set; }
            public string User_name { get; set; }
            public string Password { get; set; }
            public string Ph_number { get; set; }
            public string Email { get; set; }
            public string Department { get; set; }
    }
    public class UserLogin
    {
        public string User_name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

}
