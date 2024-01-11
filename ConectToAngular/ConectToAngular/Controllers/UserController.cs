using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace ConectToAngular.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {

        // GET: api/Trip
        [HttpGet]
        [Route("api/user")]
        public List<Entities.User> GetAllUser()
        {

            return UserBL.GetAllUser();



        }

        [HttpGet]
        [Route("api/user/{UserId}")]
        // GET: api/Trip/5
     
        public Entities.User GetUser(int UserId)
        {
            return BL.UserBL.GetUser(UserId);

            //return DB.lstTrip.Where(item => { item.TripCode == id });

        }



        //// POST: api/Trip
        [HttpPost]
        [Route("api/createUser")]
        ////עדכון
        public int Post([FromBody] User User)
        {
          return  UserBL.AddUser(User);
        }

        //// PUT: api/Trip/5
        [HttpPut]

        public int Put( [FromBody] User t)
        {
          return  UserBL.UpdateUser( t);
        }
        //[HttpPut]
        //public void Put([FromBody] Trip t)
        //{
        //    //int id = DB.lstTrip.Count;
        //    //Trip t = new Trip() { TripCode = ++id, NumMishtatfim = numms, TripName = namet, TripDate = DateTime.Today };
        //    DB.lstTrip.Add(t);
        //}



        //// DELETE: api/Trip/5
        [HttpDelete]
        //מוחקת
        public int Delete([FromBody] int id)
        {
           return UserBL.DeleteUser(id);

        }


    }
}
