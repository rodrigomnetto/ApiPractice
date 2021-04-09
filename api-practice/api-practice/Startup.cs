using ApiPractice.DbContexts;
using ApiPractice.Services.Interfaces;
using ApiPractice.Services.User;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ApiPractice
{
    public class Startup
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            RegisterDatabase(services);
            RegisterAutoMapper(services);
            RegisterServices(services);

            services.AddControllers();
        }

        public void RegisterDatabase(IServiceCollection services)
        {
            var databaseOptions = Configuration.GetSection(DatabaseSettings.Database).Get<DatabaseSettings>();
            services.AddDbContext<ApiPracticeDbContext>(options => options.UseNpgsql(databaseOptions.ConnectionString));
        }

        public void RegisterAutoMapper(IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(Startup).Assembly);
            });

            services.AddSingleton(config.CreateMapper());
        }

        public void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
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

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ServiceProvider = app.ApplicationServices;
        }
    }
}
