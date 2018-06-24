using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebPlatform.Models;

namespace WebPlatform.DataLayer.Repository.Definitions
{
    static internal class UserDefinitions
    {
        public static void Set(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(k => k.Id);
            modelBuilder.Entity<User>().Property(p => p.FirstName).IsRequired().HasMaxLength(100).IsUnicode();
            modelBuilder.Entity<User>().Property(p => p.LastName).IsRequired().HasMaxLength(100).IsUnicode();
            modelBuilder.Entity<User>().Property(p => p.Email).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(p => p.Phone).IsOptional().HasMaxLength(15);
            modelBuilder.Entity<User>().Property(p => p.Lastonline).IsRequired().HasColumnType("datetime2");
            modelBuilder.Entity<User>().Property(p => p.Registerdate).IsRequired().HasColumnType("datetime2");
            modelBuilder.Entity<User>().Property(p => p.Ip).IsRequired().HasMaxLength(16);
        }
    }
}