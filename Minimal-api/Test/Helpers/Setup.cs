using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Minimal_api;
using Minimal_api.Dominio.Entidades;
using Minimal_api.Dominio.Interfaces;
using Minimal_api.Infraestrutura.Db;
using Test.Mocks;

namespace Test.Helpers
{
    public class Setup
    {
        public const string PORT = "5001";
        public static TestContext testContext = default;
        public static WebApplicationFactory<Startup> http = default;
        public static HttpClient client = default;


        public static void ClassInit(TestContext testContext)
        {
            Setup.testContext = testContext;
            Setup.http = new WebApplicationFactory<Startup>();

            Setup.http = Setup.http.WithWebHostBuilder(builder =>
            {
                builder.UseSetting("https_port", Setup.PORT).UseEnvironment("Testing");
                builder.ConfigureServices(services =>
                {
                    services.AddScoped<iAdministradorServico, AdministradorServicoMock>();
                });
            });

            Setup.client = Setup.http.CreateClient();
        }

        public static void ClassCleanup()
        {
            Setup.http.Dispose();
        }
    }
}