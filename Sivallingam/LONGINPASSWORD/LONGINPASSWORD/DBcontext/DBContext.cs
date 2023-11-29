using LONGINPASSWORD.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Collections.Generic;

namespace LONGINPASSWORD.DBcontext
{  
        public class DbContact : DbContext
        {
            public DbContact(DbContextOptions options) : base(options) { }
            public DbSet<student> Logins2 { get; set; }
        }
}
