using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using APITestGraphQL.Database;
using APITestGraphQL.Api;
using Microsoft.EntityFrameworkCore;
using HotChocolate.AspNetCore.Playground;
using HotChocolate.AspNetCore;
using HotChocolate;
using APITestGraphQL.Models;
using APITestGraphQL.Intefaces;
using APITestGraphQL.Services;

namespace APITestGraphQL
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
            services.AddDbContext<BancoFHTContext>(o => o.UseSqlServer(Configuration.GetConnectionString("BancoFHTGraphQL")));

            services.AddGraphQL(p => SchemaBuilder.New().AddServices(p)
               .AddType<ContaFHT>()
               .AddQueryType<Query>()
               .AddMutationType<Mutation>()
               .Create());


            services

               // Business rules
               .AddScoped<IDepositoService, DepositoService>()
               .AddScoped<ISaqueService, SaqueService>()
               .AddScoped<ICriarContaService, CriarContaService>()
               .AddScoped<ISaldoConta, SaldoConta>();
               
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions { QueryPath = "/api", Path = "/Playground" });
            }

            app.UseGraphQL("/api");

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
