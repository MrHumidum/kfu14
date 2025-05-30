using System;
using System.Windows.Forms;
using TaskManager.Core.Interfaces;
using TaskManager.Core.Models;

namespace TaskManager.UI
{
    public partial class MainForm : Form
    {
        private readonly ITaskService _taskService;

        public MainForm(ITaskService taskService)
        {
            _taskService = taskService;
            InitializeComponent();
            LoadTasksAsync();
        }

        private async void LoadTasksAsync()
        {
            var tasks = await _taskService.GetTasksAsync();
            taskListBox.Items.Clear();
            foreach (var task in tasks)
                taskListBox.Items.Add(task);
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            await _taskService.AddTaskAsync(inputBox.Text);
            LoadTasksAsync();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem is TaskItem task)
            {
                task.Title = inputBox.Text;
                await _taskService.UpdateTaskAsync(task);
                LoadTasksAsync();
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem is TaskItem task)
            {
                await _taskService.DeleteTaskAsync(task.Id);
                LoadTasksAsync();
            }
        }
    }
}
