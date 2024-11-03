
using System.ComponentModel.DataAnnotations;

namespace InsuranceQuote.Models
{
    public class Insuree
    {
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int CarYear { get; set; }

        [Required]
        public string CarMake { get; set; }

        public string CarModel { get; set; }

        [Required]
        public int SpeedingTickets { get; set; }

        public bool DUI { get; set; }
        
        public bool FullCoverage { get; set; }

        public decimal Quote { get; set; }
    }
}
