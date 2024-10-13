using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    public class ProductComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        [MinLength(2), MaxLength(500)]
        public string Text { get; set; }

        [Required]
        [Range(1, 5)]
        public byte StarCount { get; set; }

        [Required]
        public bool IsConfirmed { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}