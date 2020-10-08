using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public List<Inventory> Inventorys { get; set; }

    }
}