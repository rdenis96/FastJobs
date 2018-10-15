using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebPlatform.Models;

namespace WebPlatform.DataLayer.Repository.Definitions
{
    static internal class PersonalProfileDefinitions
    {
        public static void Set(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalProfile>().HasKey(p => p.Id);
            modelBuilder.Entity<PersonalProfile>().Property(p => p.Image).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<PersonalProfile>().Property(p => p.Born).IsRequired().HasColumnType("datetime2");
            modelBuilder.Entity<PersonalProfile>().Property(p => p.Gender).IsOptional();
            modelBuilder.Entity<PersonalProfile>().Property(p => p.BornCountry).IsOptional().HasMaxLength(100).IsUnicode();
            modelBuilder.Entity<PersonalProfile>().Property(p => p.Address).IsOptional().HasMaxLength(255).IsUnicode();
            modelBuilder.Entity<PersonalProfile>().Property(p => p.Studies).IsOptional().HasMaxLength(255).IsUnicode();
            modelBuilder.Entity<PersonalProfile>().Property(p => p.Hobbies).IsOptional();
            modelBuilder.Entity<PersonalProfile>().Property(p => p.MaritalStatus).IsOptional().HasMaxLength(100);
            modelBuilder.Entity<PersonalProfile>().Property(p => p.About).IsOptional().HasMaxLength(255);

            modelBuilder.Entity<PersonalProfile>().HasRequired(p => p.User).WithRequiredDependent(p => p.PersonalProfile);
        }
    }
}