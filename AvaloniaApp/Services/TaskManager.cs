using System;
using System.Collections.Generic;
using System.Linq;
using AvaloniaApp.interfaces;
using AvaloniaApp.Models;

namespace AvaloniaApp.Services
{
    public class TaskManager : ITaskManager
    {   

        private readonly List<Task> _tasks;

        public TaskManager()
        {
            _tasks = new List<Task>();
        }
        public void AddTask(Task task)
        {
            if (task != null)
            {
                _tasks.Add(task);
                System.Console.WriteLine(task.Title);
            }
        }
        public void DeleteTask(Task task)
        {
            if (_tasks.Contains(task))
            {
                _tasks.Remove(task);
            }
        }
        public void UpdateTask(Task task)
        {
            var index = _tasks.FindIndex(t => t.ID == task.ID);
            if (index != -1)
            {
                _tasks[index] = task;
            }
        }
        public List<Task> GetAllTasks()
        {
            return _tasks;
        }
    }
}