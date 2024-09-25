using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [Required]
        [StringLength(100)]
        public string Name { get; set; } 

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; } 

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } 

        [Required]
        [StringLength(50)]
        public string UserType { get; set; } 
    }
}
