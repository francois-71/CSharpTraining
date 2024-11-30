namespace AvaloniaApp.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Title { get; set; } // Ensure this is public and has a getter and setter
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
