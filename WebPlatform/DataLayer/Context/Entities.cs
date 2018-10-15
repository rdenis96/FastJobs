using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebPlatform.DataLayer.Repository.Definitions;
using WebPlatform.Models;

namespace WebPlatform.DataLayer.Context
{
    public class Entities : DbContext
    {
        public Entities() : base("name=Entities")
        {
            //code first, database first, model first
            Database.SetInitializer<Entities>(new CreateDatabaseIfNotExists<Entities>());
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PersonalProfile> PersonalProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            UserDefinitions.Set(modelBuilder);
            PersonalProfileDefinitions.Set(modelBuilder);
        }
    }
}