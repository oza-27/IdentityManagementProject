using System.ComponentModel.DataAnnotations;

namespace IdentityManagementProject.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
