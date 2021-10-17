using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_1.Models;

    public class LogInContext : DbContext
    {
        public LogInContext (DbContextOptions<LogInContext> options)
            : base(options)
        {
        }

        public DbSet<Project_1.Models.LogIn> LogIn { get; set; }
    }
