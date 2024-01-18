using System;

namespace MyTodoApp.Models
{

    public class todo
    {
        public int Id { get; set;}
        public string Title { get; set;}
        public bool Done { get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public string User { get; set; }
    }
}