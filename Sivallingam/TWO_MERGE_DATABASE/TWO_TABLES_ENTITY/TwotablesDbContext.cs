using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWO_TABLES_ENTITY.DbModel;

namespace TWO_TABLES_ENTITY
{
    public class TwotablesDbContext : DbContext
    {
        public TwotablesDbContext(DbContextOptions options) : base(options) { }
      
        public DbSet<SIVA_DETAILS> SIV_DETAILS { get; set; }
        public DbSet<KAPILAN_DETAILS> KAPILAN_DETAILS { get; set; }

    }
}
