using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSVC.DAL
{
    public class PaymentDBContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }
       

        public PaymentDBContext(DbContextOptions<PaymentDBContext> options):base(options)
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
