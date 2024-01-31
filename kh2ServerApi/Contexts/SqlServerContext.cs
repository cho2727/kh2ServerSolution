using kh2ServerApi.Infrastructure.Reverse;
using Microsoft.EntityFrameworkCore;

namespace kh2ServerApi.Contexts;

public class SqlServerContext : KH2emsServerContext
{
    public SqlServerContext(IConfiguration configuration) : base(configuration)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string? connectionString = _configuration.GetConnectionString("Server");
            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(3).TotalSeconds));
        }
    }

}
