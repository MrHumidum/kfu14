using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Core.Interfaces;
using TaskManager.DataAccess;
using TaskManager.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using NLog;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;


namespace TaskManager.Infrastructure
{
    public static class IoCContainer
    {
        public static ServiceProvider Configure()
        {
            LogManager.Setup().LoadConfigurationFromFile("nlog.config");
            var services = new ServiceCollection();
            services.AddLogging(logging =>
            {
                logging.ClearProviders();
                logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
                logging.AddNLog();
            });
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=tasks.db"));

            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITaskService, TaskService>();

            return services.BuildServiceProvider();
        }
    }
}