using System.ComponentModel.DataAnnotations;

namespace APIDemo.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [Phone]
        public string Contact { get; set; } = string.Empty;
    }
}
