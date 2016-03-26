using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlinePayment.Models
{
    public class Electronic
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string DeviceName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        //public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string Remarks { get; set; }
    }

     

    public class ElectronicDBContext : DbContext
    {
        public DbSet<Electronic> Electronics { get; set; }
    }
}