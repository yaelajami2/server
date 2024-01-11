using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database6:DbContext
    {
        static Database6()
        {
            Database.SetInitializer(new Initializer());
            new TripDAL().InitTrips();
        }
        public DbSet<TripPrice> TripPrice { get; set; }
        public DbSet<CompanyOfProfession> CompanyOfProfession { get; set; }
        public DbSet< TripSite> TripSite { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<RequestTrip> RequestTrip { get; set; }
        public DbSet<Definition> Definition { get; set; }
    }
}
