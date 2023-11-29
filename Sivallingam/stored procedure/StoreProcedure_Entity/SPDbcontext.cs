using Microsoft.EntityFrameworkCore;
using StoreProcedure_Entity.Dbmodal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedure_Entity
{
    public class SPDbcontext :DbContext
    {
        public SPDbcontext(DbContextOptions options) : base(options) { }
        public DbSet<modal> SIV_DETAILS { get; set; }
        public DbSet<KAPILAN_DETAILS> KAPILAN_DETAILS { get; set; }
    }
}
