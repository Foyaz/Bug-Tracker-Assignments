﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerAssignment_1.Models.Classes
{
    public class RoomStatus
    {
        public int Id { get; set; }
        public RoomStatus()
        {
            Rooms = new HashSet<Room>();
        }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}