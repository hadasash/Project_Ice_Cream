using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_1.Models;

    public class FlavorUserContext : DbContext
    {
        public FlavorUserContext (DbContextOptions<FlavorUserContext> options)
            : base(options)
        {
        }

        public DbSet<Project_1.Models.FlavorUser> FlavorUser { get; set; }
    }
