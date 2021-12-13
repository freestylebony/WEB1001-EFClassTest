using EFClassTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFClassTest.Data
{
    public class EFClassTestContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
            //    @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");

            //using sqlite
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\USER\Desktop\EFTestDb.db");
        }


    }
}
