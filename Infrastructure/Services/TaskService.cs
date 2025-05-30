using Microsoft.Extensions.Logging;
using TaskManager.Core.Interfaces;
using TaskManager.Core.Models;

namespace TaskManager.Infrastructure.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;
        private readonly ILogger<TaskService> _logger;

        public TaskService(ITaskRepository repository, ILogger<TaskService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<List<TaskItem>> GetTasksAsync()
        {
            _logger.LogInformation("Fetching all tasks...");
            return await _repository.GetAllAsync();
        }

        public async Task AddTaskAsync(string title)
        {
            _logger.LogInformation("Adding task: {Title}", title);
            await _repository.AddAsync(new TaskItem { Title = title });
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            _logger.LogInformation("Updating task: {Id} - {Title}", task.Id, task.Title);
            await _repository.UpdateAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            _logger.LogInformation("Deleting task with ID: {Id}", id);
            await _repository.DeleteAsync(id);
        }
    }
}
