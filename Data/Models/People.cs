using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class People : Entity<long>
    {
        #region CTOR
        public People(string fName, string lName, string title)
        {
            fName = FirstName;
            lName = FirstName;
            title = Title;
        }

        #endregion

        #region PROP
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        #endregion
    }
}
