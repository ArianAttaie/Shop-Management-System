using Data.FakeDatabase;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class InvoiceServices
    {
        /// <summary>
        /// Read All / Load
        /// </summary>
        /// <returns></returns>
        public List<Invoice> GetAll()
        {
            return FakeDbContext.invoices;
        }
        /// <summary>
        /// Read One / Find
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Invoice Get(long id)
        {
            return FakeDbContext.invoices.Where(e => e.ID == id).FirstOrDefault();
        }
    }
}
