using Africa.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Africa.Server
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; protected set; }
        public Startup(IWebHostEnvironment env)
        {
            this.Environment = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSpaStaticFiles(options => { options.RootPath = "wwwroot"; });
            services.AddControllers();

            string conn = Configuration.GetConnectionString("ApplicationTable");
            services.AddDbContext<ApplicationsContext>(opt => opt.UseSqlServer(conn));

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(builder =>
            {
                builder
                    .WithOrigins("https://localhost:5173")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { 
                endpoints.MapControllers(); 
                endpoints.MapFallbackToFile("/index.html"); 
            });
            //app.UseSpaStaticFiles();
            //app.UseSpa(builder =>
            //{
            //    if (env.IsDevelopment())
            //    {
            //        builder.UseProxyToSpaDevelopmentServer("https://localhost:5173");
            //    }
            //});
        }
    }
}
