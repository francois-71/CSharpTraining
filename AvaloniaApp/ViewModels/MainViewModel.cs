using System.Collections.ObjectModel;
using System.ComponentModel;
using AvaloniaApp.Models;
using AvaloniaApp.interfaces;

namespace AvaloniaApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ITaskManager _taskManager;
        private ObservableCollection<Task> _tasks;
        public ObservableCollection<Task> Tasks
        {
            get => _tasks;
            set
            {
                if (_tasks != value)
                {
                    _tasks = value;
                    OnPropertyChanged(nameof(Tasks));
                }
            }
        }

        private Task _newTask;
        public Task NewTask
        {
            get => _newTask;
            set
            {
                if (_newTask != value)
                {
                    _newTask = value;
                    OnPropertyChanged(nameof(NewTask));
                }
            }
        }

        public MainViewModel(ITaskManager taskManager)
        {
            _taskManager = taskManager;
            _tasks = new ObservableCollection<Task>(_taskManager.GetAllTasks());
            _newTask = new Task();
        }

        public void AddTask()
        {
            if (NewTask != null && !string.IsNullOrEmpty(NewTask.Title))
            {
                _taskManager.AddTask(NewTask);
                Tasks.Add(NewTask);
                NewTask = new Task();
            }
        }

        public void DeleteTask(Task task)
        {
            _taskManager.DeleteTask(task);
            Tasks.Remove(task);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
