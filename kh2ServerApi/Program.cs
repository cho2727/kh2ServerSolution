using kh2ServerApi.Extensions;
using kh2ServerApi.Infrastructure;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;

var configurationBuilder = new ConfigurationBuilder()
  .AddJsonFile("appsettings.json", false, true)
  .AddJsonFile($"appsettings.Development.json", optional: true)
  .Build();

Environment.SetEnvironmentVariable("BASEDIR", AppDomain.CurrentDomain.BaseDirectory);
Log.Logger = new LoggerConfiguration()
  .ReadFrom.Configuration(configurationBuilder)
  .CreateBootstrapLogger();

try
{
    Log.Information("프로그램 시작");
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Kh2Server API", Version = "v1" });
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.Http,
            Name = "Bearer",
            BearerFormat = "JWT",
            Description = "Please enter authorization key",
            Scheme = "Bearer"
        });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme()
                    {
                         Reference = new OpenApiReference()
                         {
                             Type = ReferenceType.SecurityScheme,
                             Id = "Bearer"
                         }
                    },
                    Enumerable.Empty<string>().ToList()
                }
            });
        c.CustomSchemaIds(x => x.FullName?.Replace("+", "."));
    });
    builder.Services.Configure<SwaggerGeneratorOptions>(opts =>
    {
        opts.InferSecuritySchemes = true;
    });

    builder.Host.UseSerilog((context, configuration) => configuration
                                               .ReadFrom
                                               .Configuration(context.Configuration));

    builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AssemblyHelper.GetAllAssemblies().ToArray()));

    #region ConnectionString
    string connectionString = builder.Configuration.GetConnectionString("Server") ?? string.Empty;
    var provider = builder.Configuration.GetSection("DbProvider").Value ?? "MySql";
    //    configurationBuilder
    builder.Services.AddServerAccessServices(connectionString, provider);
    #endregion
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch (Exception ex)
{
    string type = ex.GetType().Name;
    if (type.Equals("StopTheHostException", StringComparison.Ordinal))
        throw;
    if (type.Equals("HostAbortedException", StringComparison.Ordinal))
        throw;
    Log.Fatal(ex, $"{type} Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
