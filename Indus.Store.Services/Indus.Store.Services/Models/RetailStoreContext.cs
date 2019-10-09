using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Indus.Store.DataObjects;
namespace Indus.Store.Models
{
    public class RetailStoreContext : DbContext
    {
        public DbSet<Customer_Payment_Detail> Customer_Payment_Details { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order_Item> Order_Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ref_Product_Type> Ref_Product_Types { get; set; }
        public DbSet<Ref_Invoice_Status> Ref_Invoice_Statuses { get; set; }
        public DbSet<Ref_Order_Item_Status> Ref_Order_Item_Statuses { get; set; }
        public DbSet<Ref_Payment_Type> Ref_Payment_Types { get; set; }
        public DbSet<Shipment_Item> Shipment_Items { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) //.SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Controllers.ModelConnectionString"));
        }
    }
}
