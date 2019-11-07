using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCintro.Models
{
    public class MyWebsiteDBContext : DbContext
    {
        public MyWebsiteDBContext (DbContextOptions<MyWebsiteDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVCintro.Models.Product> Product { get; set; }
    }
}
