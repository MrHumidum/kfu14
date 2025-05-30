namespace TaskManager.Core.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public override string ToString() => Title;


    }
}
