using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerAssignment_1.Models.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Title { get; set; }

        public Employee()
        {
            Rooms = new HashSet<Room>();
            EmployeeApprovedRooms = new HashSet<Room>();
        }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Room> EmployeeApprovedRooms { get; set; }
    }
}