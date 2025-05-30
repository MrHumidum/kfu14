using TaskManager.Core.Interfaces;
using TaskManager.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace TaskManager.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var serviceProvider = IoCContainer.Configure();
            Application.Run(new MainForm(serviceProvider.GetRequiredService<ITaskService>()));
        }
    }
}