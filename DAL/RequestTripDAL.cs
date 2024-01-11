using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
public class RequestTripDAL
    {
        public static void Delete(Entities.RequestTrip t)
        {
            using (Database6 ctx = new Database6())
            {
                ctx.RequestTrip.Remove(t);
                ctx.SaveChanges();
            }
        }

    }
}
