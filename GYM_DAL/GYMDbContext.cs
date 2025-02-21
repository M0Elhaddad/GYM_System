using GYM_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL
{
    public class GYMDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsetting.json")
                .Build();
            string? connectString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BillOfSale> BillOfSales { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<TypeOfExercise> TypeOfExercises { get; set; }
        public DbSet<TypeOfSubscription> TypeOfSubscriptions { get; set; }
        public DbSet<ProductBillDetails> productBillDetails { get; set; }
        public DbSet<productPurchaseDetails> productPurchaseDetails { get; set; }

    }
}
