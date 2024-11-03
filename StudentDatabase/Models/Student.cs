
using System.ComponentModel.DataAnnotations;

namespace StudentDatabase.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public int Age { get; set; }
    }
}
