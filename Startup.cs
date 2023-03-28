using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Catalogo.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Catalogo
{
    class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        { }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
        { }
    }
}


