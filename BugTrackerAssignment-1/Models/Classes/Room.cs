using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerAssignment_1.Models.Classes
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }


        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int RoomStatusId { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }

        public Room()
        {
            RoomTypes = new HashSet<RoomType>();
        }
        public virtual ICollection<RoomType> RoomTypes { get; set; }

        public int EmployeeRentalId { get; set; }
        public virtual Employee EmployeeRental { get; set; }

        public int? EmployeeApprovalId { get; set; }
        public virtual Employee EmployeeApproval { get; set; }

    }
}