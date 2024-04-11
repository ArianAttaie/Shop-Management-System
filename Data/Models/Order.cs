using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order : Entity<long>
    {
        #region CTOR
        public Order(string custFullName, string prdctName, int qty, decimal unitPrice)
        {
            CustFullName = custFullName;
            PrdctName = prdctName;
            QTY = qty;
            UnitPrice = unitPrice;
        }
        #endregion

        #region PROP
        public string CustFullName { get; set; }
        public string PrdctName { get; set; }
        public int QTY { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice
        {
            get { return UnitPrice * Convert.ToDecimal(QTY); }
        }
        #endregion
    }
}
