using ApiPractice.DbContexts;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApiPractice
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
            RegisterDatabase(services);
            RegisterAutoMapper(services);

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
        }
    }
}
