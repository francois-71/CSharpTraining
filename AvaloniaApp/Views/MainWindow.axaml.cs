using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApp.Models;
using AvaloniaApp.Services;
using AvaloniaApp.ViewModels;

namespace AvaloniaApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(new TaskManager());
        }

        // The methods for handling button clicks go here
        public void OnAddTaskClick(object sender, RoutedEventArgs e)
        {
            // Call AddTask in your ViewModel when the button is clicked
            if (DataContext is MainViewModel viewModel)
            {
                viewModel.AddTask();
            }
        }

        public void OnDeleteTaskClick(object sender, RoutedEventArgs e)
        {
            // Handle delete task logic here
            if (sender is Button button && button.DataContext is Task task)
            {
                if (DataContext is MainViewModel viewModel)
                {
                    viewModel.DeleteTask(task);
                }
            }
        }
    }
}
