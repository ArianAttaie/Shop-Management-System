using Data.FakeDatabase;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PeopleServices
    {
        /// <summary>
        /// Read All / Load
        /// </summary>
        /// <returns></returns>
        public List<People> GetAll()
        {
            return FakeDbContext.people;
        }
        /// <summary>
        /// Read One / Find
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<People> Get(long id)
        {
            People p = FakeDbContext.people.Where(e => e.ID == id).FirstOrDefault();
            List<People> pL = new List<People>() {p};
            return pL;
        }
        /// <summary>
        /// Create / Insert
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="title"></param>
        public void Post(string fname, string lname, string title)
        {
            People p = new People(fname, lname, title);
            FakeDbContext.people.Add(p);
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="title"></param>
        public void Put(long id, string fname, string lname, string title)
        {
            People p = FakeDbContext.people.Where(e => e.ID == id).FirstOrDefault();
            p.FirstName = fname == "" ? p.FirstName : fname;
            p.LastName = lname == "" ? p.LastName : lname;
            p.Title = title == "" ? p.Title : title;
        }
        /// <summary>
        /// Remove / Delete
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {
            People p = FakeDbContext.people.Where(e => e.ID == id).FirstOrDefault();
            FakeDbContext.people.Remove(p);
        }
    }
}
