using BaseApiCore.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace BaseApiCore.Data
{
   public class LicDBContext : DbContext,IDbContext
    {
        public LicDBContext(DbContextOptions<LicDBContext> options)
        : base(options)
        {

        }

        public DbSet<State> State { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    throw new NotImplementedException();
        //}

        //public int SaveChanges()
        //{
        //    this.ChangeTracker.AutoDetectChangesEnabled = true;
        //    return base.SaveChanges();
        //}
    }
}
