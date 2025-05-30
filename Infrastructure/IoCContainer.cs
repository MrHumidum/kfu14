using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Core.Interfaces;
using TaskManager.DataAccess;
using TaskManager.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Infrastructure
{
    public static class IoCContainer
    {
        public static ServiceProvider Configure()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=tasks.db"));

            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITaskService, TaskService>();

            return services.BuildServiceProvider();
        }
    }
}