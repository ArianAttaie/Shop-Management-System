﻿using System;
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
            CustFullName = custFullName;
            CustID = custID;
            PrdctName = prdctName;
            PrdctID = prdctID;
            QTY = qty;
            UnitPrice = unitPrice;
            TotalPrice = total;
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
