﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoWebApiAspNetCore.Database;
using EstudoWebApiAspNetCore.Repositories;
using EstudoWebApiAspNetCore.Repositories.Interfaces;
using EstudoWebApiAspNetCore.Services;
using EstudoWebApiAspNetCore.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EstudoWebApiAspNetCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MimicContext>(opt => {
                opt.UseSqlite("Data Source=Database\\Mimic.db");
            });
            services.AddMvc();
            services.AddScoped<IPalavraRepository, PalavraRepository>(); //registra repositories
            services.AddScoped<IPalavraService, PalavraService>(); //registra services
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
