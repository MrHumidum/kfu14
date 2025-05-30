using TaskManager.Core.Interfaces;
using TaskManager.Core.Models;

namespace TaskManager.Infrastructure.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public Task<List<TaskItem>> GetTasksAsync() => _repository.GetAllAsync();

        public Task AddTaskAsync(string title) => _repository.AddAsync(new TaskItem { Title = title });

        public Task UpdateTaskAsync(TaskItem task) => _repository.UpdateAsync(task);

        public Task DeleteTaskAsync(int id) => _repository.DeleteAsync(id);
    }
}