﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAD_CA_PROJECT_INVEST.Model
{
    public class Order
    {
        [Key]
        [DisplayName("Order ID")]
        [Required(ErrorMessage =("Order ID required"))]
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Purchase Price is required")]
        [DisplayName("Purchase Price (€)")]
        public float PurchasePrice { get; set; }
        
        //navigation properties
        public int StockID { get; set; }
        public virtual Stock Stock { get; set; }
        
        public int UserID { get; set; }
        public virtual User User { get; set; }

    }
}
