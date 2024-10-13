using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(3), MaxLength(6)]
        public string Color { get; set; }

        [Required]
        [MinLength(2), MaxLength(50)]
        public string IconCssClass { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}