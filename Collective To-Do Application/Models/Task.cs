using System.ComponentModel.DataAnnotations;
using System;

namespace Collective_To_Do_Application.Models
{
    public class Task
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public Person? NextPerformer { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsDone { get; set; }
        public string? Description { get; set; }
    }
}