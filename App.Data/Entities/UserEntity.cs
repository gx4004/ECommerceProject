using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(2), MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2), MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [Required]
        public bool Enabled { get; set; } = true;

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}