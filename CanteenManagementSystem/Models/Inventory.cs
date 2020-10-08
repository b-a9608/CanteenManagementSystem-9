using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    public class Inventory
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CategoryID { get; set; }
        public Category category { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }


        public List<Item> Items { get; set; }
    }
}