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
            await _taskService.AddTaskAsync($"Исполнитель: {userInputBox.Text} | Задача: {taskInputBox.Text} | Дедлайн: {dateTimeInputBox.Text}");
            LoadTasksAsync();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem is TaskItem task)
            {
                task.Title = $"Исполнитель: {userInputBox.Text} | Задача: {taskInputBox.Text} | Дедлайн: {dateTimeInputBox.Text}";
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

        private async void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem is TaskItem task)
            {
                var parts = task.Title.Split(" | ");
                foreach (var part in parts)
                {
                    if (part.StartsWith("Исполнитель:"))
                        userInputBox.Text = part.Replace("Исполнитель:", "").Trim();
                    else if (part.StartsWith("Задача:"))
                        taskInputBox.Text = part.Replace("Задача:", "").Trim();
                    else if (part.StartsWith("Дедлайн:") && DateTime.TryParse(part.Replace("Дедлайн:", "").Trim(), out var dt))
                        dateTimeInputBox.Value = dt;
                }
            }
        }
    }
}

