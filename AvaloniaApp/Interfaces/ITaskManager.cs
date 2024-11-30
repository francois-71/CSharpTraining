using System.Collections.Generic;
using AvaloniaApp.Models;

namespace AvaloniaApp.interfaces
{
    public interface ITaskManager
    {
        public void AddTask(Task task);
        public void DeleteTask(Task task);
        public void UpdateTask(Task task);

        public List<Task> GetAllTasks();
    }
}