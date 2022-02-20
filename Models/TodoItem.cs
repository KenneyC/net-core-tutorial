using System;
namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComlete { get; set; }
    }
}
