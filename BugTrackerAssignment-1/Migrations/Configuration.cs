namespace BugTrackerAssignment_1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BugTrackerAssignment_1.Models.Classes;

    internal sealed class Configuration : DbMigrationsConfiguration<BugTrackerAssignment_1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BugTrackerAssignment_1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var Room = new Room();
            Room.Id = 1;
            Room.RoomNumber = 1;
            Room.CustomerId = 1;
            Room.RoomStatusId = 1;
            Room.EmployeeRentalId = 1;
            Room.EmployeeApprovalId = 1;
        }
    }
}
