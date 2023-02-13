using System.ComponentModel.DataAnnotations;

namespace IdentityManagementProject.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
