using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.FakeDatabase
{
    public class FakeDbContext
    {
        public static List<People> people = new List<People>()
        {
            new People("Arian","Ataei", "Customer") { ID = 1 },
            new People("Abbas","Kiarostami", "Staff") { ID = 2 }
        };

        public static List<Product> products = new List<Product>()
        {
            new Product("Toshiba Satelite", "Laptop", 45000000, 3) { ID = 1 },
            new Product("Dell Latitude", "Laptop", 80000000, 1) { ID = 2 },
            new Product("SSD Lexar 256GB SATA", "Storage", 12000000, 5) { ID = 3 }
        };

        public static List<Order> orders = new List<Order>()
        {
            new Order("Arian Ataei", "SSD Lexar 256GB SATA", 2, 12000000) { ID = 1 }
        };

        public static List<Invoice> invoices = new List<Invoice>();
    }
}
