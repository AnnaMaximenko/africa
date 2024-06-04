using africa.Data;
using Microsoft.EntityFrameworkCore;
using VueCliMiddleware;

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

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // NOTE: PRODUCTION Ensure this is the same path that is specified in your webpack output
        services.AddSpaStaticFiles(opt => opt.RootPath = "wwwroot");
        services.AddControllers();
        string conn = Configuration.GetConnectionString("ApplicationTable");
        services.AddDbContext<ApplicationsContext>(opt => opt.UseSqlServer(conn));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapFallbackToFile("index.html");
        });
    }
}