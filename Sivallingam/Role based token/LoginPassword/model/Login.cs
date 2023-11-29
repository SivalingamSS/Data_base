using System.ComponentModel.DataAnnotations;

namespace LoginPassword.model
{
    public class register
    {
        [Key]
        public int user_Id { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public string Ph_number { get; set; }
        public string Email { get; set;}
        public string Department { get; set;}
    }
       
    
    public class UserModel
    {
        public string User_name { get; set; }
        public string Password { get; set;}
        public string Role { get; set;}
    }
    public class UserLogin
    {
        public string User_name { get; set; }
        public string Password { get; set; }
    }
        public class UserConstants
    {
            public static List<UserModel> Users = new()
            {
                    new UserModel(){ User_name="naveem",Password="naveem_admin",Role="Admin"}
            };
    }

}
