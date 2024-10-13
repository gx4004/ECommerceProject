using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        [MinLength(2)]
        public string OrderCode { get; set; }

        [Required]
        [MinLength(2), MaxLength(250)]
        public string Address { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}