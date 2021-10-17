using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_1.Models;

    public class FlavorsContext : DbContext
    {
        public FlavorsContext (DbContextOptions<FlavorsContext> options)
            : base(options)
        {
        }

        public DbSet<Project_1.Models.Flavor> Flavor { get; set; }
    }
