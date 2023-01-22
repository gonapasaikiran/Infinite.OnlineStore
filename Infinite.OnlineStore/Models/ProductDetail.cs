using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Infinite.OnlineStore.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Discount { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public PackSize PackSize { get; set; }
        public int PackSizeId { get; set; }
        [Required]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}