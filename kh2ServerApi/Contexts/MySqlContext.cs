using kh2ServerApi.Infrastructure.Reverse;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace kh2ServerApi.Contexts;

public class MySqlContext : KH2emsServerContext
{
    public MySqlContext(IConfiguration configuration) : base(configuration)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string? connectionString = _configuration.GetConnectionString("Server");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
