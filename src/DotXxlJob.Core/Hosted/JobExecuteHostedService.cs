using System.Threading;
using System.Threading.Tasks;
using DotXxlJob.Core.Config;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace DotXxlJob.Core
{
    /// <summary>
    ///  NOTE: 负责启动Executor服务，和进行服务注册的宿主服务
    /// </summary>
    public class JobsExecuteHostedService : BackgroundService
    {
        private readonly IExecutorRegistry _registry;
        private readonly IOptions<XxlJobExecutorOptions> _options;

        public JobsExecuteHostedService(IExecutorRegistry registry, IOptions<XxlJobExecutorOptions> options)
        {
            this._registry = registry;
            _options = options;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (_options.Value.AutoRegistry)
            {
                return this._registry.RegistryAsync(stoppingToken);
            }
            return Task.CompletedTask;
        }

    }
}