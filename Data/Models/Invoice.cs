using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Invoice : Entity<long>
    {
        #region CTOR
        public Invoice(string custFullName, long custID, string prdctName, int prdctID, int qty, decimal unitPrice, decimal total)
        {
            custFullName = CustFullName;
            custID = CustID;
            prdctName = PrdctName;
            prdctID = PrdctID;
            qty = QTY;
            unitPrice = UnitPrice;
            total = TotalPrice;
        }
        #endregion

        #region PROP
        public string CustFullName { get; set; }
        public long CustID { get; set; }
        public string PrdctName { get; set; }
        public int PrdctID { get; set; }
        public int QTY { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        #endregion
    }
}
