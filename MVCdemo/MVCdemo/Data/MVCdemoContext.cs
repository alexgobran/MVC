﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCdemo.Models;

namespace MVCdemo.Models
{
    public class MVCdemoContext : DbContext
    {
        public MVCdemoContext (DbContextOptions<MVCdemoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCdemo.Models.Vendor> Vendor { get; set; }

        public DbSet<MVCdemo.Models.Product> Product { get; set; }
    }
}
