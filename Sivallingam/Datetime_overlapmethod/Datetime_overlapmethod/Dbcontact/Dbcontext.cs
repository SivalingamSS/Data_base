using Datetime_overlapmethod.model;
using Microsoft.EntityFrameworkCore;

namespace Datetime_overlapmethod.Dbcontact
{
    public class Dbcontext :DbContext
    {
         public Dbcontext(DbContextOptions options) : base(options) { }
        
        public DbSet<MODEL> SIV_DATETIME { get;set; }

    }
}
