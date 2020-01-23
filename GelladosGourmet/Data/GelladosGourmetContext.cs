using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GelladosGourmet.Models
{
    public class GelladosGourmetContext : DbContext
    {
        public GelladosGourmetContext (DbContextOptions<GelladosGourmetContext> options)
            : base(options)
        {
        }

        public DbSet<GelladosGourmet.Models.Department> Department { get; set; }
    }
}
