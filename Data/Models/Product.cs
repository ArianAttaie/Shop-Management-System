using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product : Entity<int>
    {
        #region CTOR
        public Product(string name, string category, decimal unitPrice, int quantity)
        {
            Name = name;
            Category = category;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        #endregion

        #region PROP
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        #endregion
    }
}
