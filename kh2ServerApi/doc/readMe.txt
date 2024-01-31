1. 데이터베이스 리버스 엔지니어링
	dotnet ef dbcontext scaffold "Data Source=192.168.1.205;Database=k_h2ems_server;User Id=sa;Password=20wellsdb19!@;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer --context-dir Infrastructure/Reverse --output-dir Infrastructure/Reverse/Models
	dotnet ef dbcontext scaffold "Data Source=127.0.0.1,51433;Database=k_h2ems_server;User Id=sa;Password=choshin01)!;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer --context-dir Infrastructure/Reverse --output-dir Infrastructure/Reverse/Models
    
    
    dotnet ef dbcontext scaffold "Server=192.168.1.142,3306;Database=k_h2ems_server;User=root;Password=choshin01;" "Pomelo.EntityFrameworkCore.MySql" -t personsView -o Infrastructure/Reverse/Models
    dotnet ef dbcontext scaffold "Server=192.168.1.142,3306;Database=k_h2ems_server;User=root;Password=choshin01;" "Pomelo.EntityFrameworkCore.MySql" --context-dir Infrastructure/Reverse --output-dir Infrastructure/Reverse/Models

	    protected readonly IConfiguration _configuration;

    public KH2emsServerContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }