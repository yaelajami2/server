using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Initializer:DropCreateDatabaseIfModelChanges<Database6>
    {
        protected override void Seed(Database6 context)
        {
            //todo: call function to add data
            new TripDAL().InitTrips();
        }
    }
}
