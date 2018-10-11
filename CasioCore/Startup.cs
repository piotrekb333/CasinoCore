using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CasioCore.Configuration;
using CasioCore.Services.Implementations;
using CasioCore.Services.Interfaces;
using DAL.Casino.Context;
using DAL.Casino.Repositories.Implementations;
using DAL.Casino.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySql.Data.EntityFrameworkCore.Extensions;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
namespace CasioCore
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

            var st = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<WebApiContext>(
                options => options.UseMySql(st,
                mysqlOptions =>
                     {
                         mysqlOptions.ServerVersion(new Version(5, 5, 0), ServerType.MySql); // replace with your Server Version and Type
                     }
            ));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();

            //-----REPOSITORIES-----
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<INewsletterRepository, NewsletterRepository>();
            services.AddTransient<ICasinoRepository, CasinoRepository>();

            //-----SERVICES-----
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IArticleService, ArticleService>();
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<INewsletterService, NewsletterService>();
            services.AddTransient<ICasinoService, CasinoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            loggerFactory.AddLog4Net();
        }
    }
}
