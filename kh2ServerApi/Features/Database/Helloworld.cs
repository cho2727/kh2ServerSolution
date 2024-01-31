using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace kh2ServerApi.Features.Database;

public class Helloworld
{
    public class Command : IRequest<Response>
    {
    }

    public class Response
    {
        public string Message { get; set; } = string.Empty;
    }

    public class CommandHandler : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var response = new Response { 
                Message = "Hello World???11111"
            };

            return await Task.FromResult(response);
        }
    }
}
