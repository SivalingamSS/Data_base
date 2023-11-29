using Microsoft.EntityFrameworkCore;
using LoginPassword.model;

namespace LoginPassword.Dbcontact
{
    public class Dbcontact1 : DbContext
    {
        public Dbcontact1 ( DbContextOptions  options) : base(options) { }
        public DbSet<register> Logins2 { get; set; }
       
    }
}
