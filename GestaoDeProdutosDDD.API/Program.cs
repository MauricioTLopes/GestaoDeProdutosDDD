using Autofac.Extensions.DependencyInjection;
using GestaoDeProdutosDDD.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace GestaoDeProdutosDDD.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}