using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerAssignment_1.Models.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string  Notes { get; set; }

        public Customer()
        {
            Rooms = new HashSet<Room>();
        }
        public virtual ICollection<Room> Rooms { get; set; }

    }
}