using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CustomerID { get; set; }
        public Customer customer { get; set; }


        [Required]
        public int InventoryID { get; set; }
        public Inventory inventory { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }


       
    }
}