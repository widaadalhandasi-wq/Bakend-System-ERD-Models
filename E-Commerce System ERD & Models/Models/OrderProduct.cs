using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System_ERD___Models.Models
{
    public class OrderProduct
    {
        [Required]
        public int orderId { get; set; }   //Composite Primary Key   //user input

        [Required]
        public int productId { get; set; }  //Composite Primary Key    //user input

        [Required]
        [Range(1, 999)]
        public int quantity { get; set; }  //user input

        // Navigation Properties
        public  Order Order { get; set; }  //one order have many order product

        // Navigation Properties
        public Product product { get; set; }  //one Product have many order product

    }
}
