using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using ZamilAlarms;
using ZamilAlarms.Database;


[assembly: FunctionsStartup(typeof(ZamilAlarms.StartUp))]
namespace ZamilAlarms
{
    public class StartUp : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string connectionString = "Data Source = octopusdigitalsql.database.windows.net; Initial Catalog = OMNIConnect; Persist Security Info = True; User ID = octopusdigital; Password = avanceon@786"; //Environment.GetEnvironmentVariable("ConnectionString");
            builder.Services.AddDbContext<OmniConnectDB>(
              options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionString));
            builder.Services.AddLogging();
            //builder.Services.AddScoped(Log);
        }
    }
}
