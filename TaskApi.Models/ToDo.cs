namespace WebAPI.Models
{
    public class ToDo
    {
        public int ID { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }

        public DateTime Due { get; set; }

        public ToDoStatus Status { get; set; }

    }
}
