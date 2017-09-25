using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.StaticFilesEx;

namespace LisaEhrich
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }
   /*     internal class ConfigurationBuilder
        {
            public ConfigurationBuilder()
            {
            }
        }

        internal object SetBasePath(string ContentRootPath)
        {
            throw new NotImplementedException();
        }


       public Startup(IHostingEnvironment env)
        {


            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            string sAppPath = env.ContentRootPath; //Application Base Path
            string swwwRootPath = env.WebRootPath;  //wwwroot folder path
            ConfigurationBuilder = builder.Build();
        }*/



        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}