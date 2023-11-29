using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role_Entity.Dbcontext
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Admin> Admin_details { get; set; }
        public DbSet<student> student_details { get; set; }
        public DbSet<teacher> teacher_detailss { get; set; }

    }
}
