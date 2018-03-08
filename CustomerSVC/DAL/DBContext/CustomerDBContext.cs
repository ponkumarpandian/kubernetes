using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSVC.DAL
{
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }


        public CustomerDBContext(DbContextOptions<CustomerDBContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //.AddJsonFile("appsettings.json")
            //.Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("CustomerConnection"));


            base.OnConfiguring(optionsBuilder);
        }

    }
}
