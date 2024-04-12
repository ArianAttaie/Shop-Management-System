using Data.FakeDatabase;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductServices
    {
        /// <summary>
        /// Read All / Load
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAll()
        {
            return FakeDbContext.products;
        }
        /// <summary>
        /// Read One / Find
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Product> Get(int id)
        {
            Product p = FakeDbContext.products.Where(e => e.ID == id).FirstOrDefault();
            List<Product> pL = new List<Product>() {p};
            return pL;
        }
        /// <summary>
        /// Create / Insert
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="unitPrice"></param>
        /// <param name="quantity"></param>
        public void Post(string name, string category, decimal unitPrice, int quantity)
        {
            Product p = new Product(name, category, unitPrice, quantity);
            FakeDbContext.products.Add(p);
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="unitPrice"></param>
        /// <param name="quantity"></param>
        public void Pus(int id, string name, string category, decimal unitPrice, int quantity)
        {
            Product p = FakeDbContext.products.Where(e => e.ID == id).FirstOrDefault();
            p.Name = name == "" ? p.Name : name;
            p.Category = category == "" ? p.Category : category;
            p.UnitPrice = unitPrice == default ? p.UnitPrice : unitPrice;
            p.Quantity = quantity == default ? p.Quantity : quantity;
        }
        /// <summary>
        /// Remove / Delete
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            Product p = FakeDbContext.products.Where(e => e.ID == id).FirstOrDefault();
            FakeDbContext.products.Remove(p);
        }
    }
}
