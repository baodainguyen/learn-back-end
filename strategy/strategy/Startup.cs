using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using strategy.DAL;


namespace strategy
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
            services.AddDistributedMemoryCache();

            string connAppsetting = "ConnPC037";    // "ConnStr";
            services.AddDbContext<AccountContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString(connAppsetting)));
            services.AddDbContext<ProjectGroupContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString(connAppsetting)));
            services.AddDbContext<CrmContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString(connAppsetting)));


            SettingCache(ref services, connAppsetting);
            // end cache settings

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            services.AddControllers()
                .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddControllers().AddNewtonsoftJson();
            
        }
        void SettingCache(ref IServiceCollection services, string connAppsetting)
        {
            // run in .NET CLI (make sure install: dotnet tool install --global dotnet-sql-cache)
            // dotnet sql-cache create "Data Source=PC-037;Initial Catalog=test.stratsigner.com;Integrated Security=True" dbo TestCache
            services.AddDistributedSqlServerCache(options => {
                options.ConnectionString = Configuration[connAppsetting];
                options.SchemaName = "dbo";
                options.TableName = "TestCache";
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                //endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "account",
                    pattern: "{controller=Account}/{action}/{id?}");
            });
        }
    }
}
