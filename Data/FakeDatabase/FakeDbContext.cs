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
        public static List<People> people = new List<People>();

        public static List<Product> products = new List<Product>();

        public static List<Order> orders = new List<Order>();

        public static List<Invoice> invoices = new List<Invoice>();
    }
}
