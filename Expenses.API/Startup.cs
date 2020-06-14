using Expenses.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SqlWrapper;

namespace Expenses.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IExpensesService, ExpensesService>();
            services.AddTransient<ISqlWrapper>(
                serviceProvider => new SqlWrapper.SqlWrapper(@"Data Source=DESKTOP-6KQ96MP\MSSQLSERVER2017;Initial Catalog=ExpensesGod;Integrated Security=True"));

            //services.AddCors(options => 
            //{
            //    options.AddPolicy(name: "MySpecificCors",
            //        builder => 
            //        {
            //            builder.WithOrigins("https://localhost:44379/", "https://localhost:44340/")
            //            .AllowAnyMethod()
            //            .AllowAnyHeader();
            //        });
            //});

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder => builder.AllowAnyOrigin());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
