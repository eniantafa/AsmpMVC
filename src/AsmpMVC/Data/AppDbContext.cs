using AsmpMVC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsmpMVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext()
        {
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<ProgressStage> ProgressStages { get; set; }
        public DbSet<Variation> Variations { get; set; }
    }
}
