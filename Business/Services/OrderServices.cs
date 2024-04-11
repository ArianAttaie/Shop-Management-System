using Data.FakeDatabase;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class OrderServices
    {
        /// <summary>
        /// Read All / Load
        /// </summary>
        /// <returns></returns>
        public List<Order> GetAll()
        {
            return FakeDbContext.orders;
        }

        // --------------------------------------------------------------------------------------
        // For whenever a Customer's Interface is made; But until now we won't add this method 
        
        ///// <summary>
        ///// Create Order
        ///// </summary>
        ///// <param name="fname"></param>
        ///// <param name="lname"></param>
        ///// <param name="title"></param>
        //public void Post(string custFullName, string prdctName, int qty, decimal unitPrice)
        //{
        //    Order order = new Order(custFullName, prdctName, qty, unitPrice);
        //    FakeDbContext.orders.Add(order);
        //}
        // --------------------------------------------------------------------------------------

        /// <summary>
        /// Accept / Acceptance of the Order and adding it to the Invoice section
        /// </summary>
        /// <param name="id"></param>
        public void Accept(long id)
        {
            Order order = FakeDbContext.orders.Where(e => e.ID == id).FirstOrDefault();
            People pep = FakeDbContext.people.Where(e => e.FullName == order.CustFullName).FirstOrDefault();
            Product prdct = FakeDbContext.products.Where(e => e.Name == order.PrdctName).FirstOrDefault();

            string custFullName = order.CustFullName;
            long custID = pep.ID;
            string prdctName = order.PrdctName;
            int prdctID = prdct.ID;
            int qty = order.QTY;
            decimal unitPrice = order.UnitPrice;
            decimal total = order.TotalPrice;

            Invoice invoice = new Invoice(custFullName, custID, prdctName, prdctID, qty, unitPrice, total);

            FakeDbContext.orders.Remove(order);
        }
        /// <summary>
        /// Decline / Rejection of the Order and deleting it / Delete
        /// </summary>
        /// <param name="id"></param>
        public void Decline(long id)
        {
            Order order = FakeDbContext.orders.Where(e => e.ID == id).FirstOrDefault();
            FakeDbContext.orders.Remove(order);
        }
    }
}
