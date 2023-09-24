using System.ComponentModel.DataAnnotations;

namespace Collective_To_Do_Application.Models
{
    /// <summary>
    /// A class that includes data about the user
    /// </summary>
    public class Person
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string PinCode { get; set; }
    }
}