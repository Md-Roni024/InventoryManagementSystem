﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Product Product { get; set; } 

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        public string Seller { get; set; }
    }
}
