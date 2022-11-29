using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todo_apllication.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreateTime { get; set; }
        public enum Status { Completed, InProgress, NotStarted }
    }
}
