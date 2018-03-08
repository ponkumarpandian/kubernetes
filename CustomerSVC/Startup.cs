using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSVC.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace CustomerSVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //var builder = new ConfigurationBuilder()
            //.AddJsonFile("appSettings.json");
            //Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //services.AddSingleton<IConfiguration>(Configuration);


            // Read and configure the connection string
            //services.AddEntityFrameworkSqlServer().AddDbContext<CustomerDBContext>(p=>p.UseInternalServiceProvider())


            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration["ConnectionStrings:CustomerConnection"];

            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<CustomerDBContext>(options => options.UseSqlServer(connectionString));



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
