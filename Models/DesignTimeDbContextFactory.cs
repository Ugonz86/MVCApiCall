using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MVCApiCall.Models
{
  public class MVCApiCallContextFactory : IDesignTimeDbContextFactory<MVCApiCallContext>
  {

    MVCApiCallContext IDesignTimeDbContextFactory<MVCApiCallContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<MVCApiCallContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new MVCApiCallContext(builder.Options);
    }
  }
}