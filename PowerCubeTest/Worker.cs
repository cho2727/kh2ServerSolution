using Smart.PowerCUBE.Api;

namespace PowerCubeTest
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            PowerCubeDemo.GetMidLive();
            //PowerCubeDemo.GetControlPointNames();
            //PowerCubeDemo.GetEventPointNames();
            //PowerCubeDemo.GetMessagePointNames();
            //PowerCubeDemo.GetRealPointNames();
            PowerCubeDemo.GetRealPointDataWithTypeName();
            //PowerCubeDemo.GetRealPointDataWithTypeNameList();
            //PowerCubeDemo.UpdateRealDataPoint();
            //PowerCubeDemo.GetCubeBoxInfo();
            PowerCubeDemo.ServerInfo();
            await Task.CompletedTask;
        }
    }
}
