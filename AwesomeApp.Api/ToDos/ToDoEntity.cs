using System;

namespace AwesomeApp.Api.ToDos
{
    public class ToDoEntity
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public ToDoPriority Priority { get; set; }
    }
}
