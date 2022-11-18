using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyCore.Data;
using EmptyCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmptyCore
{
    public class Startup
    {
        private IConfiguration _configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddDbContext<EmptyCoreDbContext>(
                options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EmptyCore;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddScoped<IRestaurantData, SqlRestaurantData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app
            , IHostingEnvironment env
            ,IConfiguration configuration
            ,IGreeter greeter
            ,ILogger<Startup> logger
            )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseRewriter(new RewriteOptions().AddRedirectToHttpsPermanent());
            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);
            //app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            //app.Run(async (context) =>
            //{
            //    var Greeting = $"{greeter.GetMessageOfDay()}: {env.EnvironmentName}";
            //    await context.Response.WriteAsync(Greeting);
            //});
        }
    }
}

            //app.Use(next =>
            //{
            //    return async context =>
            //    {
            //        logger.LogInformation("Request Incoming");
            //        if (context.Request.Path.StartsWithSegments("/mym"))
            //        {
            //            await context.Response.WriteAsync("hit!");
            //            logger.LogInformation("Request Handle");
            //        }
            //        else
            //        {
            //            await next(context);
            //            logger.LogInformation("Response outgiong");
            //        }
            //    };
            //});
            //app.UseWelcomePage(new WelcomePageOptions
            //{
            //    Path = "/wel"
            //});
            //Greeter greeter = new Greeter();